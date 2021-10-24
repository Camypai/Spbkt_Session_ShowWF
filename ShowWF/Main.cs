using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShowWF
{
    public partial class Main : Form
    {
        private Avg         _avg;
        private OneDimArray _oneDimArray;
        private QuadEquat   _quadEquat;
        private TwoDimArray _twoDimArray;
        private Seasons     _seasons;
        private Db          _db;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _avg         = new Avg();
            _oneDimArray = new OneDimArray();
            _quadEquat   = new QuadEquat();
            _twoDimArray = new TwoDimArray();
            _seasons     = new Seasons();
            _db          = new Db();
        }

        private void avgBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_avg is null)
            {
                _avg = new Avg();
            }
            _avg.Show();
        }

        private void oneDimArrayBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_oneDimArray is null)
            {
                _oneDimArray = new OneDimArray();
            }
            _oneDimArray.Show();
        }

        private void quadEquatBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_quadEquat is null)
            {
                _quadEquat = new QuadEquat();
            }
            _quadEquat.Show();
        }

        private void twoDimArrayBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_twoDimArray is null)
            {
                _twoDimArray = new TwoDimArray();
            }
            _twoDimArray.Show();
        }

        private void seasonsBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_seasons is null)
            {
                _seasons = new Seasons();
            }
            _seasons.Show();
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_db is null)
            {
                _db = new Db();
            }
            _db.Show();
        }

        private void HideForms()
        {
            _avg.Hide();
            _oneDimArray.Hide();
            _quadEquat.Hide();
            _twoDimArray.Hide();
            _seasons.Hide();
            _db.Hide();
        }
    }
}