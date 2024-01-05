using System;
using System.Windows.Forms;
using BizHawk.Client.Common;

namespace Rayman3GBABizHawkTool;

[ExternalTool("Rayman 3 GBA Tool", Description = "Tool for Rayman 3 GBA")]
public partial class MainForm : Form, IExternalToolForm
{
    #region Constructor

    public MainForm()
    {
        InitializeComponent();

        GamesComboBox.Items.Clear();
        GamesComboBox.Items.Add(new Rayman2_PreAlpha_20020301());
        GamesComboBox.Items.Add(new Rayman2_PreAlphaB_20020308());
        GamesComboBox.Items.Add(new Rayman3_FocusGroup_20020318());
        GamesComboBox.Items.Add(new Rayman3_NintendoE3Approval_20020418());
        GamesComboBox.Items.Add(new Rayman3_E3GameCube_20020513());

        GamesComboBox.SelectedIndex = 0;
    }

    #endregion

    #region Private Properties

    private Game CurrentGame { get; set; }
    private Frame NextFrame { get; set; }
    private bool HasSwitchedFrame { get; set; }

    #endregion

    #region API

    [RequiredApi]
    public IMemoryApi Mem { get; set; }

    public void UpdateValues(ToolFormUpdateType type)
    {
        switch (type)
        {
            case ToolFormUpdateType.PostFrame:
                if (HasSwitchedFrame)
                {
                    FrameManager.DisableCustomFunction(Mem, CurrentGame);
                    HasSwitchedFrame = false;
                }
                else if (NextFrame != null)
                {
                    FrameManager.InjectCustomFunction(Mem, CurrentGame, NextFrame);
                    FrameManager.EnableCustomFunction(Mem, CurrentGame);
                    NextFrame = null;
                    HasSwitchedFrame = true;
                }
                break;
        }
    }

    public void Restart() { }
    public bool AskSaveChanges() => true;

    public bool IsActive => true;
    public bool IsLoaded => true;

    #endregion

    #region Event Handlers

    private void FramesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        SwitchFrameButton.Enabled = FramesListBox.SelectedIndex != -1;
    }

    private void SwitchFrameButton_Click(object sender, EventArgs e)
    {
        NextFrame = CurrentGame.Frames[FramesListBox.SelectedIndex];
    }

    private void GamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetGame((Game)GamesComboBox.SelectedItem);
    }

    #endregion

    #region Private Methods

    private void SetGame(Game game)
    {
        CurrentGame = game;

        FramesListBox.Items.Clear();
        foreach (Frame frame in CurrentGame.Frames)
            FramesListBox.Items.Add(frame.Name);

        SwitchFrameButton.Enabled = false;
    }

    #endregion
}