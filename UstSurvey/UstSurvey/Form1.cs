﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UstSurvey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new UstSurveyDBEntities())
            {
                var firstRaw = dbContext.Table.FirstOrDefault();

                if (firstRaw != null)
                {
                    MessageBox.Show(firstRaw.Test);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
    }
}
