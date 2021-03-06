﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using FontAwesome.Sharp;

namespace MachineLearningForKids
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MakeMeHappy formMeHappy;
        private Titanic formTitanic;
        private JudgeaBook formJudgeaBook;
        private JournetToSchool formJournetToSchool;
        private SmartClass frmSmartClass;
        private HeadlinesEasy frmheadlinesEasy;
        private ChatBots frmChatBots;
        private Snap frmSnap;
        private Chameleon frmChameleon;
        private WhatDoesTwitterThinks frmTwitter;
        public Form1()
        {
            InitializeComponent();
            
         
        }

      
      

        private void Form1_Load(object sender, EventArgs e)
        {
          
            


        }

    

        private void gamesBtn_Click(object sender, EventArgs e)
        {

            gamesPanel.Visible = true;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            gamesPanel.Visible = false;

        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void makeMeHappy_Click(object sender, EventArgs e)
        {
            formMeHappy = new MakeMeHappy();
            formMeHappy.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void titanicTile_Click(object sender, EventArgs e)
        {
           formTitanic= new Titanic();
            formTitanic.ShowDialog();
        }

        private void judgeabookTile_Click(object sender, EventArgs e)
        {
            formJudgeaBook = new JudgeaBook();
            formJudgeaBook.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            formJournetToSchool = new JournetToSchool();
            formJournetToSchool.ShowDialog();
        }

        private void tile_SmartClass_Click(object sender, EventArgs e)
        {
            frmSmartClass = new SmartClass();
            frmSmartClass.ShowDialog();
        }

        private void tileHeadline_Click(object sender, EventArgs e)
        {
            frmheadlinesEasy = new HeadlinesEasy();
            frmheadlinesEasy.ShowDialog();
        }

        private void gamesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tile_ChatBots_Click(object sender, EventArgs e)
        {
            frmChatBots = new ChatBots();
            frmChatBots.ShowDialog();
        }

        private void tileSnap_Click(object sender, EventArgs e)
        {
            frmSnap = new Snap();
            frmSnap.ShowDialog();
        }

        private void tileChameleon_Click(object sender, EventArgs e)
        {
            frmChameleon = new Chameleon();
            frmChameleon.ShowDialog();
        }

        private void tileTwitter_Click(object sender, EventArgs e)
        {
            frmTwitter = new WhatDoesTwitterThinks();
            frmTwitter.ShowDialog();
        }
    }
}
