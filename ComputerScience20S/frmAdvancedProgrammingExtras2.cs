using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    public partial class frmAdvancedProgrammingExtras2 : Form
    {

        ShooterGameObject hero;
        ShooterGameObject bullet;
        ShooterGameObject[] enemies;
        ShooterGameObject[] enemyBullets;
        ShooterGameObject[] planets;
        ShooterGameObject[] walls;

        const string DIRECTORY_1 = "\\ComputerScience20S\\bin\\Debug";
        const string DIRECTORY_2 = "\\ComputerScience20S\\Resources\\";

        const string SOUND_ENEMY_BULLET   = "enemyBullet.wav";
        const string SOUND_HERO_BULLET    = "heroBullet.wav";
        const string SOUND_KEY            = "key.wav";
        const string SOUND_ENEMY_EXPLODE  = "enemyExplosion.wav";
        const string SOUND_PLANET_EXPLODE = "planetExplosion.wav";

        string directory = Directory.GetCurrentDirectory().Replace(DIRECTORY_1, DIRECTORY_2);



        public frmAdvancedProgrammingExtras2()
        {
            InitializeComponent();
        }

        private void frmAdvancedProgrammingExtras2_Load(object sender, EventArgs e)
        {
            picHeroBullet.Visible = false;
            picEnemyBullet0.Visible = false;
            picEnemyBullet1.Visible = false;
            picEnemyBullet2.Visible = false;
            picEnemyBullet3.Visible = false;
            picEnemyBullet4.Visible = false;
            picEnemyBullet5.Visible = false;

            tmrEnemies.Enabled = true;
            tmrHero.Enabled = true;
            tmrEnemyFireDelay.Enabled = true;
            tmrEnemyBullets.Enabled = true;
            tmrHeroBullet.Enabled = true;

            tmrEnemyBullets.Interval = 1;
            tmrEnemies.Interval = 1;
            tmrEnemyFireDelay.Interval = 1000;
            tmrHero.Interval = 1;
            tmrHeroBullet.Interval = 1;

            enemies = new ShooterGameObject[6];
            enemyBullets = new ShooterGameObject[6];
            planets = new ShooterGameObject[3];
            walls = new ShooterGameObject[4];

            hero = new ShooterGameObject(picHero, 5, Directions.STOP);
            bullet = new ShooterGameObject(picHeroBullet, 5, Directions.UP);

            enemies[0] = new ShooterGameObject(picEnemy0, 1, Directions.LEFT);
            enemies[1] = new ShooterGameObject(picEnemy1, 1, Directions.LEFT);
            enemies[2] = new ShooterGameObject(picEnemy2, 1, Directions.LEFT);
            enemies[3] = new ShooterGameObject(picEnemy3, 1, Directions.LEFT);
            enemies[4] = new ShooterGameObject(picEnemy4, 1, Directions.LEFT);
            enemies[5] = new ShooterGameObject(picEnemy5, 1, Directions.LEFT);

            enemyBullets[0] = new ShooterGameObject(picEnemyBullet0, 3, Directions.DOWN);
            enemyBullets[1] = new ShooterGameObject(picEnemyBullet1, 3, Directions.DOWN);
            enemyBullets[2] = new ShooterGameObject(picEnemyBullet2, 3, Directions.DOWN);
            enemyBullets[3] = new ShooterGameObject(picEnemyBullet3, 3, Directions.DOWN);
            enemyBullets[4] = new ShooterGameObject(picEnemyBullet4, 3, Directions.DOWN);
            enemyBullets[5] = new ShooterGameObject(picEnemyBullet5, 3, Directions.DOWN);

            planets[0] = new ShooterGameObject(picPlanet0, 0, Directions.STOP);
            planets[1] = new ShooterGameObject(picPlanet1, 0, Directions.STOP);
            planets[2] = new ShooterGameObject(picPlanet2, 0, Directions.STOP);

            walls[0] = new ShooterGameObject(picWall0, 0, Directions.STOP);
            walls[1] = new ShooterGameObject(picWall1, 0, Directions.STOP);
            walls[2] = new ShooterGameObject(picWall2, 0, Directions.STOP);
            walls[3] = new ShooterGameObject(picWall3, 0, Directions.STOP);

        }

        private void frmAdvancedProgrammingExtras2_MouseClick(object sender, MouseEventArgs e)
        {
            if (bullet.image.Visible == false)
            {
                tmrHeroBullet.Enabled = true;
                bullet.image.Visible = true;
                bullet.centerOn(hero);
                bullet.redraw();
                axWindowsMediaPlayer1.URL = directory + SOUND_HERO_BULLET;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void frmAdvancedProgrammingExtras2_KeyDown(object sender, KeyEventArgs e)
        {
            axWindowsMediaPlayer1.URL = directory + SOUND_KEY;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (e.KeyCode == Keys.Left) hero.direction = Directions.LEFT;
            else if (e.KeyCode == Keys.Right) hero.direction = Directions.RIGHT;
            else hero.direction = Directions.STOP;
        }

        private void tmrEnemyFireDelay_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int choice = random.Next(0, 6);
            if (enemies[choice].image.Visible == true)
            {
                if (enemyBullets[choice].image.Visible == false)
                {
                    axWindowsMediaPlayer1.URL = directory + SOUND_ENEMY_BULLET;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    enemyBullets[choice].image.Visible = true;
                    enemyBullets[choice].centerOn(enemies[choice]);
                    enemyBullets[choice].redraw();
                }
            }
        }

        private void tmrEnemyBullets_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyBullets.Length; i++)
            {
                if (enemyBullets[i].image.Visible == true)
                {
                    enemyBullets[i].move();
                    for (int j = 0; j < walls.Length; j++)
                    {
                        if (enemyBullets[i].isColliding(walls[j]))
                        {
                            enemyBullets[i].image.Visible = false;
                        }
                    }
                    for (int j = 0; j < planets.Length; j++)
                    {
                        if (planets[j].image.Visible == true)
                        {
                            if (enemyBullets[i].isColliding(planets[j]))
                            {
                                enemyBullets[i].image.Visible = false;
                            }
                        }
                    }
                    if (enemyBullets[i].isColliding(hero))
                    {
                        hero.image.Visible = false;
                        tmrEnemyBullets.Enabled = false;
                        MessageBox.Show("Game Over!");
                        Application.Exit();
                    }
                    enemyBullets[i].redraw();
                }
            }
        }

        private void tmrEnemies_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].move();
                for (int j = 0; j < walls.Length; j++)
                {
                    if (enemies[i].isColliding(walls[j]))
                    {
                        enemies[i].bounceOff(walls[j]);
                    }
                }
                enemies[i].redraw();
            }
        }

        private void tmrHeroBullet_Tick(object sender, EventArgs e)
        {
            if (bullet.image.Visible == true)
            {
                bullet.move();
                for (int i = 0; i < walls.Length; i++)
                {
                    if (bullet.isColliding(walls[i]))
                    {
                        bullet.image.Visible = false;
                    }
                }
                for (int i = 0; i < planets.Length; i++)
                {
                    if (planets[i].image.Visible == true)
                    {
                        if (bullet.isColliding(planets[i]))
                        {
                            axWindowsMediaPlayer1.URL = directory + SOUND_PLANET_EXPLODE;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            planets[i].image.Visible = false;
                            bullet.image.Visible = false;
                        }
                    }
                }
                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i].image.Visible == true)
                    {
                        if (bullet.isColliding(enemies[i]))
                        {
                            axWindowsMediaPlayer1.URL = directory + SOUND_ENEMY_EXPLODE;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            enemies[i].image.Visible = false;
                            bullet.image.Visible = false;
                        }
                    }
                }
                bullet.redraw();
            }
        }

        private void tmrHero_Tick(object sender, EventArgs e)
        {
            hero.move();
            for (int i = 0; i < walls.Length; i++)
            {
                if (hero.isColliding(walls[i]))
                {
                    hero.stickTo(walls[i]);
                }
            }
            hero.redraw();
        }
    }
}
