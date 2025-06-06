﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENCYCLE
{
    public partial class AdminMain1 : Form
    {
        private Form currentChildForm;
        private UserList userListForm;
        private AdminDB adminDB;
        private EditRates editRates;
        private Statistics statistics;
        private Rewards rewards;
        public AdminMain1()
        {
            InitializeComponent();
            HighlightButton(btnDashboard); 
            adminDB = new AdminDB(this);   
            LoadFormIntoPanel(adminDB);
        }

        public void LoadFormIntoPanel(Form childForm)
        {
            if (currentChildForm != null && currentChildForm.GetType() == childForm.GetType())
                return;

            if (currentChildForm != null)
                currentChildForm.Hide();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            paneldisplayDB.Controls.Clear();
            paneldisplayDB.Controls.Add(childForm);
            childForm.Show();

            currentChildForm = childForm;
        }

        private void HighlightButton(Button btn)
        {
            DisableButton(); 
            btn.BackColor = Color.Lime;
        }

        private void DisableButton()
        {
            btnDashboard.BackColor = Color.Transparent;
            btnUsers.BackColor = Color.Transparent;
            btnEditRates.BackColor = Color.Transparent;
            btnRewards.BackColor = Color.Transparent;
            btnStatistics.BackColor = Color.Transparent;
            btnOut.BackColor = Color.Transparent;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DisableButton();
            btnOut.BackColor = Color.Lime;
            CoverPage coverpage = new CoverPage();
            coverpage.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            paneldisplayDB.Visible = true;

            if (adminDB == null || adminDB.IsDisposed)
                adminDB = new AdminDB(this);

            LoadFormIntoPanel(adminDB);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HighlightButton(btnUsers);
            paneldisplayDB.Visible = true;

            if (userListForm == null || userListForm.IsDisposed)
                userListForm = new UserList(this);

            LoadFormIntoPanel(userListForm);
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            HighlightButton(btnEditRates);
            paneldisplayDB.Visible = true;

            if (editRates == null || editRates.IsDisposed)
                editRates = new EditRates(this);

            LoadFormIntoPanel(editRates);
        }

        private void btnRewards_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRewards);
            paneldisplayDB.Visible = true;

            if (rewards == null || rewards.IsDisposed)
                rewards = new Rewards(this);
            LoadFormIntoPanel(rewards);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStatistics);
            paneldisplayDB.Visible = true;
            if (statistics == null || statistics.IsDisposed)
                statistics = new Statistics(this);
            LoadFormIntoPanel(statistics);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
