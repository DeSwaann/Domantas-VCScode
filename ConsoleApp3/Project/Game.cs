using ConsoleApp3.Project.Scenes;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project
{
    class Game
    {
        public Player MyPlayer;
        public TitleScene MyTitleScene;
        public CreditsScene MyCreditsScene;
        public NavigationScene MyNavigationScene;
        public SkeletonScene MySkeletonScene;
        public RogueScene MyRogueScene;
        public BerserkerScene MyBerserkerScene;
        public DragonScene MyDragonScene;
        public HoodedManScene MyHoodedManScene;
        public MerchantScene MyMerchantScene;
        public EndScene MyEndScene;


        public Game()
        {
            MyPlayer = new Player();
            MyTitleScene = new TitleScene(this);
            MyCreditsScene = new CreditsScene(this);
            MyNavigationScene = new NavigationScene(this);
            MySkeletonScene = new SkeletonScene(this);
            MyRogueScene = new RogueScene(this);
            MyBerserkerScene = new BerserkerScene(this);
            MyDragonScene = new DragonScene(this);
            MyHoodedManScene = new HoodedManScene(this);
            MyMerchantScene = new MerchantScene(this);
            MyEndScene = new EndScene(this);

        }
        public void Start()
        {
            MyTitleScene.Run();

        }
    }
}
