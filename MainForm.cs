#region header

// MouseJiggle - MainForm.cs
// 
// Alistair J. R. Young
// Arkane Systems
// 
// Copyright Arkane Systems 2012-2013.
// 
// Created: 2013-08-24 12:41 PM

#endregion

using System;
using System.Windows.Forms;
using System.Reflection;

using Microsoft.Win32;

namespace ArkaneSystems.MouseJiggle
{

  public partial class MainForm : Form
  {
    private const int MOUSEMOVE = 8;

    protected bool zig = true;

    //https://stackoverflow.com/a/14364009
    protected override void OnLoad(EventArgs e)
    {
      Visible = false;
      ShowInTaskbar = false;
      base.OnLoad(e);
    }

    public MainForm()
    {
      InitializeComponent();
    }

    private void jiggleTimer_Tick(object sender, EventArgs e)
    {
      // jiggle
      if (menuZen.Checked)
        Jiggler.Jiggle(0, 0);
      else
      {
        if (zig)
          Jiggler.Jiggle(4, 4);
        else // zag
        {
          // I really don't know why this needs to be less to stay in the same
          // place; if I was likely to use it again, then I'd worry.
          Jiggler.Jiggle(-4, -4);
        }
      }

      zig = !zig;
    }

    private void menuEnable_CheckedChanged(object sender, EventArgs e)
    {
      jiggleTimer.Enabled = menuEnable.Checked;
    }

    private void cmdAbout_Click(object sender, EventArgs e)
    {
      using (var a = new AboutBox())
        a.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Arkane Systems\MouseJiggle",
                                                             RegistryKeyPermissionCheck.ReadWriteSubTree);
        var zen = (int)key.GetValue("ZenJiggleEnabled", 1);
        if (zen == 1) menuZen.Checked = true;
        else menuZen.Checked = false;
      }
      catch (Exception)
      {
        // Ignore any problems - non-critical operation.
      }
    }

    private void menuZen_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Arkane Systems\MouseJiggle",
                                                             RegistryKeyPermissionCheck.ReadWriteSubTree);
        if (menuZen.Checked)
          key.SetValue("ZenJiggleEnabled", 1);
        else
          key.SetValue("ZenJiggleEnabled", 0);
      }
      catch (Exception)
      {
        // Ignore any problems - non-critical operation.
      }
    }

    private void NifMin_Click(object sender, EventArgs e)
    {
      //nugget: ContextMenu.Show() yields a known popup positioning bug... this trick leverages notifyIcons private method that properly handles positioning
      typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(nifMin, null);
    }

    private void ContextMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
    {
      if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
        e.Cancel = true;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
