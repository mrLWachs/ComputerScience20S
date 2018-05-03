// The advanced Pacman demonstration done in class (December 2017)

using ComputerScience20S.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    public partial class frmAdvancedProgrammingExtra : Form
    {

        // global "arrays" of picture boxes for the ghosts, walls, and dots
        PictureBox[] ghostImages;
        PictureBox[] wallImages;
        PictureBox[] dotImages;
        
        // global "GameObject" class objects for the game elements
        Pacman  pacman;
        Ghost[] ghosts;
        Dot[]   dots;        
        Wall[]  walls;

        // sound playing object
        SoundPlayer player;

        public frmAdvancedProgrammingExtra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // calling "methods, functions, procedures" that sets things up
            setSoundsAndTimers();
            setUpArrays();
            setUpGameObjects();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pacman.keyPress(this, e);
        }

        private void tmrPacman_Tick(object sender, EventArgs e)
        {
            pacman.action();
        }

        private void tmrGhosts_Tick(object sender, EventArgs e)
        {
            // loop through all ghosts
            for (int i = 0; i < ghosts.Length; i++)
            {
                bool hitPacman = ghosts[i].action();
                if (hitPacman)
                {
                    loseLife();
                    return;
                }
            }
        }
                
        private void tmrPacmanAnimate_Tick(object sender, EventArgs e)
        {
            pacman.animate();
        }
                
        private void tmrGhostAnimate_Tick(object sender, EventArgs e)
        {
            // loop through all ghosts
            for (int i = 0; i < ghosts.Length; i++)
            {
                ghosts[i].animate();
            }
        }

        private void tmrDeath_Tick(object sender, EventArgs e)
        {
            // turn off the death timer
            tmrDeath.Enabled = false;

            // stop the death sound
            player.Stop();

            // display good-bye message and end application
            MessageBox.Show("Game Over");
            this.Close();
        }

        private void tmrIntro_Tick(object sender, EventArgs e)
        {            
            // start all the game timers
            tmrChomp.Enabled = true;
            tmrGhosts.Enabled = true;
            tmrPacman.Enabled = true;
            tmrPacmanAnimate.Enabled = true;
            tmrGhostAnimate.Enabled = true;

            // turn off the introduction timer
            tmrIntro.Enabled = false;

            // play the chomping sound on a loop
            player.Stop();
            player = new SoundPlayer(Properties.Resources.chomp);
            player.PlayLooping();
        }

        private void loseLife()
        {
            // stop all game timers
            tmrPacmanAnimate.Enabled = false;
            tmrGhosts.Enabled = false;
            tmrPacman.Enabled = false;
            tmrGhostAnimate.Enabled = false;

            // play the death sound
            player.Stop();
            player = new SoundPlayer(Properties.Resources.death);
            player.PlayLooping();

            // start the death delay timer
            tmrDeath.Enabled = true;
        }

        private void setSoundsAndTimers()
        {
            // start the introduction timer and turn off all other timers
            tmrIntro.Enabled = true;
            tmrChomp.Enabled = false;
            tmrDeath.Enabled = false;
            tmrGhosts.Enabled = false;
            tmrPacman.Enabled = false;
            tmrPacmanAnimate.Enabled = false;
            tmrGhostAnimate.Enabled = false;

            // play the intro sound
            player = new SoundPlayer(Properties.Resources.beginning);
            player.Play();
        }

        private void setUpGameObjects()
        {
            // put the coordinates into the pacman object
            pacman = new Pacman(picPacman);

            // loop through all the walls and assign coordinates to each wall object
            walls = new Wall[PacmanGlobals.WALLS];
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i] = new Wall(wallImages[i]);
            }

            // loop through all the dots and assign coordinates to each dot object
            dots = new Dot[PacmanGlobals.DOTS];
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = new Dot(dotImages[i]);
            }

            // loop through all the ghosts and assign coordinates to each ghost object
            // as well as assigning a random direction to each
            ghosts = new Ghost[PacmanGlobals.GHOSTS];
            for (int i = 0; i < ghosts.Length; i++)
            {
                ghosts[i] = new Ghost(ghostImages[i],i);
                ghosts[i].assign(walls);
                ghosts[i].assign(pacman);
            }

            pacman.assign(dots);
            pacman.assign(walls);
        }

        private void setUpArrays()
        {
            ghostImages = new PictureBox[PacmanGlobals.GHOSTS];
            wallImages  = new PictureBox[PacmanGlobals.WALLS];
            dotImages   = new PictureBox[PacmanGlobals.DOTS];

            // put all the ghost images into the ghost image array:
            ghostImages[0] = picBlinky;
            ghostImages[1] = picInky;
            ghostImages[2] = picPinky;
            ghostImages[3] = picClyde;

            // put all the wall images into the wall image array:
            wallImages[0] = pictureBox1;
            wallImages[1] = pictureBox2;
            wallImages[2] = pictureBox3;
            wallImages[3] = pictureBox4;
            wallImages[4] = pictureBox5;
            wallImages[5] = pictureBox6;
            wallImages[6] = pictureBox7;
            wallImages[7] = pictureBox8;
            wallImages[8] = pictureBox9;
            wallImages[9] = pictureBox10;
            wallImages[10] = pictureBox11;
            wallImages[11] = pictureBox12;
            wallImages[12] = pictureBox13;
            wallImages[13] = pictureBox14;
            wallImages[14] = pictureBox15;
            wallImages[15] = pictureBox16;
            wallImages[16] = pictureBox17;
            wallImages[17] = pictureBox18;
            wallImages[18] = pictureBox19;
            wallImages[19] = pictureBox20;
            wallImages[20] = pictureBox21;
            wallImages[21] = pictureBox22;
            wallImages[22] = pictureBox23;
            wallImages[23] = pictureBox24;
            wallImages[24] = pictureBox25;
            wallImages[25] = pictureBox26;
            wallImages[26] = pictureBox27;
            wallImages[27] = pictureBox28;
            wallImages[28] = pictureBox29;
            wallImages[29] = pictureBox30;
            wallImages[30] = pictureBox31;
            wallImages[31] = pictureBox32;
            wallImages[32] = pictureBox33;
            wallImages[33] = pictureBox34;
            wallImages[34] = pictureBox35;
            wallImages[35] = pictureBox36;
            wallImages[36] = pictureBox37;
            wallImages[37] = pictureBox38;
            wallImages[38] = pictureBox39;
            wallImages[39] = pictureBox40;
            wallImages[40] = pictureBox41;
            wallImages[41] = pictureBox42;
            wallImages[42] = pictureBox43;
            wallImages[43] = pictureBox44;

            // put all the dot images into the dot image array:
            dotImages[0] = pictureBox45;
            dotImages[1] = pictureBox46;
            dotImages[2] = pictureBox47;
            dotImages[3] = pictureBox48;
            dotImages[4] = pictureBox49;
            dotImages[5] = pictureBox50;
            dotImages[6] = pictureBox51;
            dotImages[7] = pictureBox52;
            dotImages[8] = pictureBox53;
            dotImages[9] = pictureBox54;
            dotImages[10] = pictureBox55;
            dotImages[11] = pictureBox56;
            dotImages[12] = pictureBox57;
            dotImages[13] = pictureBox58;
            dotImages[14] = pictureBox59;
            dotImages[15] = pictureBox60;
            dotImages[16] = pictureBox61;
            dotImages[17] = pictureBox62;
            dotImages[18] = pictureBox63;
            dotImages[19] = pictureBox64;
            dotImages[20] = pictureBox65;
            dotImages[21] = pictureBox66;
            dotImages[22] = pictureBox67;
            dotImages[23] = pictureBox68;
            dotImages[24] = pictureBox69;
            dotImages[25] = pictureBox70;
            dotImages[26] = pictureBox71;
            dotImages[27] = pictureBox72;
            dotImages[28] = pictureBox73;
            dotImages[29] = pictureBox74;
            dotImages[30] = pictureBox75;
            dotImages[31] = pictureBox76;
            dotImages[32] = pictureBox77;
            dotImages[33] = pictureBox78;
            dotImages[34] = pictureBox79;
            dotImages[35] = pictureBox80;
            dotImages[36] = pictureBox81;
            dotImages[37] = pictureBox82;
            dotImages[38] = pictureBox83;
            dotImages[39] = pictureBox84;
            dotImages[40] = pictureBox85;
            dotImages[41] = pictureBox86;
            dotImages[42] = pictureBox87;
            dotImages[43] = pictureBox88;
            dotImages[44] = pictureBox89;
            dotImages[45] = pictureBox90;
            dotImages[46] = pictureBox91;
            dotImages[47] = pictureBox92;
            dotImages[48] = pictureBox93;
            dotImages[49] = pictureBox94;
            dotImages[50] = pictureBox95;
            dotImages[51] = pictureBox96;
            dotImages[52] = pictureBox97;
            dotImages[53] = pictureBox98;
            dotImages[54] = pictureBox99;
            dotImages[55] = pictureBox100;
            dotImages[56] = pictureBox101;
            dotImages[57] = pictureBox102;
            dotImages[58] = pictureBox103;
            dotImages[59] = pictureBox104;
            dotImages[60] = pictureBox105;
            dotImages[61] = pictureBox106;
            dotImages[62] = pictureBox107;
            dotImages[63] = pictureBox108;
            dotImages[64] = pictureBox109;
            dotImages[65] = pictureBox110;
            dotImages[66] = pictureBox111;
            dotImages[67] = pictureBox112;
            dotImages[68] = pictureBox113;
            dotImages[69] = pictureBox114;
            dotImages[70] = pictureBox115;
            dotImages[71] = pictureBox116;
            dotImages[72] = pictureBox117;
            dotImages[73] = pictureBox118;
            dotImages[74] = pictureBox119;
            dotImages[75] = pictureBox120;
            dotImages[76] = pictureBox121;
            dotImages[77] = pictureBox122;
            dotImages[78] = pictureBox123;
            dotImages[79] = pictureBox124;
            dotImages[80] = pictureBox125;
            dotImages[81] = pictureBox126;
            dotImages[82] = pictureBox127;
            dotImages[83] = pictureBox128;
            dotImages[84] = pictureBox129;
            dotImages[85] = pictureBox130;
            dotImages[86] = pictureBox131;
            dotImages[87] = pictureBox132;
            dotImages[88] = pictureBox133;
            dotImages[89] = pictureBox134;
            dotImages[90] = pictureBox135;
            dotImages[91] = pictureBox136;
            dotImages[92] = pictureBox137;
            dotImages[93] = pictureBox138;
            dotImages[94] = pictureBox139;
            dotImages[95] = pictureBox140;
            dotImages[96] = pictureBox141;
            dotImages[97] = pictureBox142;
            dotImages[98] = pictureBox143;
            dotImages[99] = pictureBox144;
            dotImages[100] = pictureBox145;
            dotImages[101] = pictureBox146;
            dotImages[102] = pictureBox147;
            dotImages[103] = pictureBox148;
            dotImages[104] = pictureBox149;
            dotImages[105] = pictureBox150;
            dotImages[106] = pictureBox151;
            dotImages[107] = pictureBox152;
            dotImages[108] = pictureBox153;
            dotImages[109] = pictureBox154;
            dotImages[110] = pictureBox155;
            dotImages[111] = pictureBox156;
            dotImages[112] = pictureBox157;
            dotImages[113] = pictureBox158;
            dotImages[114] = pictureBox159;
            dotImages[115] = pictureBox160;
            dotImages[116] = pictureBox161;
            dotImages[117] = pictureBox162;
            dotImages[118] = pictureBox163;
            dotImages[119] = pictureBox164;
            dotImages[120] = pictureBox165;
            dotImages[121] = pictureBox166;
            dotImages[122] = pictureBox167;

            dotImages[123] = pictureBox168;
            dotImages[124] = pictureBox169;
            dotImages[125] = pictureBox170;
            dotImages[126] = pictureBox171;
            dotImages[127] = pictureBox172;
            dotImages[128] = pictureBox173;
            dotImages[129] = pictureBox174;
            dotImages[130] = pictureBox175;
            dotImages[131] = pictureBox176;
            dotImages[132] = pictureBox177;
            dotImages[133] = pictureBox178;
            dotImages[134] = pictureBox179;
            dotImages[135] = pictureBox180;
            dotImages[136] = pictureBox181;
            dotImages[137] = pictureBox182;
            dotImages[138] = pictureBox183;
            dotImages[139] = pictureBox184;
            dotImages[140] = pictureBox185;
            dotImages[141] = pictureBox186;
            dotImages[142] = pictureBox187;
            dotImages[143] = pictureBox188;
            dotImages[144] = pictureBox189;
            dotImages[145] = pictureBox190;
            dotImages[146] = pictureBox191;
            dotImages[147] = pictureBox192;
            dotImages[148] = pictureBox193;
            dotImages[149] = pictureBox194;
            dotImages[150] = pictureBox195;
            dotImages[151] = pictureBox196;
            dotImages[152] = pictureBox197;
            dotImages[153] = pictureBox198;
            dotImages[154] = pictureBox199;
            dotImages[155] = pictureBox200;
            dotImages[156] = pictureBox201;
            dotImages[157] = pictureBox202;
            dotImages[158] = pictureBox203;
            dotImages[159] = pictureBox204;
            dotImages[160] = pictureBox205;
            dotImages[161] = pictureBox206;
            dotImages[162] = pictureBox207;
            dotImages[163] = pictureBox208;
            dotImages[164] = pictureBox209;
            dotImages[165] = pictureBox210;
            dotImages[166] = pictureBox211;
            dotImages[167] = pictureBox212;
            dotImages[168] = pictureBox213;
            dotImages[169] = pictureBox214;
            dotImages[170] = pictureBox215;
            dotImages[171] = pictureBox216;
            dotImages[172] = pictureBox217;
            dotImages[173] = pictureBox218;
            dotImages[174] = pictureBox219;
            dotImages[175] = pictureBox220;
            dotImages[176] = pictureBox221;
            dotImages[177] = pictureBox222;
            dotImages[178] = pictureBox223;
            dotImages[179] = pictureBox224;
            dotImages[180] = pictureBox225;
            dotImages[181] = pictureBox226;
            dotImages[182] = pictureBox227;
            dotImages[183] = pictureBox228;
            dotImages[184] = pictureBox229;
            dotImages[185] = pictureBox230;
            dotImages[186] = pictureBox231;
            dotImages[187] = pictureBox232;
            dotImages[188] = pictureBox233;
            dotImages[189] = pictureBox234;
            dotImages[190] = pictureBox235;
            dotImages[191] = pictureBox236;
            dotImages[192] = pictureBox237;
            dotImages[193] = pictureBox238;
            dotImages[194] = pictureBox239;
            dotImages[195] = pictureBox240;
            dotImages[196] = pictureBox241;
            dotImages[197] = pictureBox242;
            dotImages[198] = pictureBox243;
            dotImages[199] = pictureBox244;
            dotImages[200] = pictureBox245;
            dotImages[201] = pictureBox246;
            dotImages[202] = pictureBox247;
            dotImages[203] = pictureBox248;
            dotImages[204] = pictureBox249;
            dotImages[205] = pictureBox250;
            dotImages[206] = pictureBox251;
            dotImages[207] = pictureBox252;
            dotImages[208] = pictureBox253;
            dotImages[209] = pictureBox254;
            dotImages[210] = pictureBox255;
            dotImages[211] = pictureBox256;
            dotImages[212] = pictureBox257;
            dotImages[213] = pictureBox258;
            dotImages[214] = pictureBox259;
            dotImages[215] = pictureBox260;
            dotImages[216] = pictureBox261;
            dotImages[217] = pictureBox262;
            dotImages[218] = pictureBox263;
            dotImages[219] = pictureBox264;
            dotImages[220] = pictureBox265;
            dotImages[221] = pictureBox266;
            dotImages[222] = pictureBox267;
            dotImages[223] = pictureBox268;
            dotImages[224] = pictureBox269;
            dotImages[225] = pictureBox270;
            dotImages[226] = pictureBox271;
            dotImages[227] = pictureBox272;
            dotImages[228] = pictureBox273;
            dotImages[229] = pictureBox274;
            dotImages[230] = pictureBox275;
            dotImages[231] = pictureBox275;
            dotImages[232] = pictureBox276;
            dotImages[233] = pictureBox277;
            dotImages[234] = pictureBox278;
            dotImages[235] = pictureBox279;
            dotImages[236] = pictureBox280;
            dotImages[237] = pictureBox281;
            dotImages[238] = pictureBox282;
            dotImages[239] = pictureBox283;
            dotImages[240] = pictureBox284;
            dotImages[241] = pictureBox285;
            dotImages[242] = pictureBox286;
            dotImages[243] = pictureBox287;
            dotImages[244] = pictureBox288;
        }

    }
}
