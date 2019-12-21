using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using WindowsGame.Common.Static;
using WindowsGame.Master;

namespace WindowsGame.Common.Managers
{
	public interface IContentManager
	{
		void Initialize();
		void LoadContent();
		void LoadContentSplash();
	}

	public class ContentManager : BaseManager, IContentManager
	{
		private String contentRoot, texturesRoot, soundRoot;

		public void Initialize()
		{
			contentRoot = GetGlobalBaseContentRoot();
			texturesRoot = String.Format("{0}/{1}/", contentRoot, Constants.TEXTURES_DIRECTORY);
			soundRoot = String.Format("{0}/{1}/", contentRoot, Constants.SOUND_DIRECTORY);
		}

		public void LoadContentSplash()
		{
			// TODO revert this - only used for testing
			String splashName = MyGame.Manager.ConfigManager.GlobalConfigData.BlankSplash ? "Splash" : "StevePro";
			Assets.SplashTexture = LoadTexture(splashName);
			//Assets.SplashTexture = LoadTexture(SPLASH_NAME);
		}

		public void LoadContent()
		{
			// Fonts.
			String fonts = String.Format("{0}/{1}/", contentRoot, Constants.FONTS_DIRECTORY);
			Assets.EmulogicFont = Engine.Content.Load<SpriteFont>(fonts + FONT_NAME);
			Assets.MenuItem = Engine.Content.Load<SpriteFont>(fonts + "MenuItem");
			Assets.Score = Engine.Content.Load<SpriteFont>(fonts + "Score");
			Assets.ScoreEvent = Engine.Content.Load<SpriteFont>(fonts + "ScoreEvent");

			// Textures.
			Assets.SpritesheetTexture = LoadTexture(SPRITE_NAME);

			// Bonus.
			Assets.AppleTexture = LoadBonusTexture("Apple");
			Assets.BananaTexture = LoadBonusTexture("Banana");
			Assets.BellTexture = LoadBonusTexture("Bell");
			Assets.CherryTexture = LoadBonusTexture("Cherry");
			Assets.KeyTexture = LoadBonusTexture("Key");
			Assets.OrangeTexture = LoadBonusTexture("Orange");
			Assets.PearTexture = LoadBonusTexture("Pear");
			Assets.PretzelTexture = LoadBonusTexture("Pretzel");
			Assets.StrawberryTexture = LoadBonusTexture("Strawberry");


			// Sprites.
			Assets.BoardTexture = LoadSpritesTexture("Board");
			Assets.BoardFlashTexture = LoadSpritesTexture("BoardFlash");
			Assets.CrumpTexture = LoadSpritesTexture("Crump");
			Assets.DyingSheetNewTexture = LoadSpritesTexture("DyingSheetNew");
			Assets.ExtraLifeTexture = LoadSpritesTexture("ExtraLife");
			Assets.GhostBaseTexture = LoadSpritesTexture("GhostBase");
			Assets.GhostBase2Texture = LoadSpritesTexture("GhostBase2");
			Assets.GhostChasedTexture = LoadSpritesTexture("GhostChased");
			Assets.GhostEyesTexture = LoadSpritesTexture("GhostEyes");
			Assets.GhostEyesCenterTexture = LoadSpritesTexture("GhostEyesCenter");
			Assets.PacManEating1Texture = LoadSpritesTexture("PacManEating1");
			Assets.PacManEating2Texture = LoadSpritesTexture("PacManEating2");
			Assets.PacManEating3Texture = LoadSpritesTexture("PacManEating3");
			Assets.PacManEating4Texture = LoadSpritesTexture("PacManEating4");
			Assets.PacManEating5Texture = LoadSpritesTexture("PacManEating5");
			Assets.PacManEating6Texture = LoadSpritesTexture("PacManEating6");
			Assets.PacManEating7Texture = LoadSpritesTexture("PacManEating7");
			Assets.PacManEating8Texture = LoadSpritesTexture("PacManEating8");
			Assets.PacManEating9Texture = LoadSpritesTexture("PacManEating9");
			Assets.PowerPillTexture = LoadSpritesTexture("PowerPill");
			Assets.SelectionTexture = LoadSpritesTexture("Selection");
			Assets.TitleTexture = LoadSpritesTexture("Title");


			// Songs.
			Assets.TitleMusicSong = Engine.Content.Load<Song>(soundRoot + TITLE_MUSIC_NAME);
			Assets.GameOverSong = Engine.Content.Load<Song>(soundRoot + GAME_OVER_NAME);

			// Sound effects.
			Assets.SoundEffectDictionary = new Dictionary<SoundEffectType, SoundEffectInstance>();
			for (SoundEffectType key = SoundEffectType.bg1; key <= SoundEffectType.newlevel; ++key)
			{
				SoundEffectInstance value = LoadSoundEffectInstance(key.ToString());
				Assets.SoundEffectDictionary.Add(key, value);
			}

			// Sound effects2.
			Assets.SoundEffectDictionary2 = new Dictionary<SoundEffectType2, SoundEffectInstance>();
			for (SoundEffectType2 key = SoundEffectType2.Right; key <= SoundEffectType2.Early; ++key)
			{
				SoundEffectInstance value = LoadSoundEffectInstance(key.ToString());
				Assets.SoundEffectDictionary2.Add(key, value);
			}
		}

		private SoundEffectInstance LoadSoundEffectInstance(String assetName)
		{
			SoundEffect effect = ContentLoad<SoundEffect>(soundRoot + assetName);
			return effect.CreateInstance();
		}
		private Texture2D LoadTexture(String assetName)
		{
			return ContentLoad<Texture2D>(texturesRoot + assetName);
		}
		private Texture2D LoadBonusTexture(String assetName)
		{
			return ContentLoad<Texture2D>(texturesRoot + "Bonus/" + assetName);
		}
		private Texture2D LoadSpritesTexture(String assetName)
		{
			return ContentLoad<Texture2D>(texturesRoot + "Sprites/" + assetName);
		}
		private static T ContentLoad<T>(String assetName)
		{
			return Engine.Content.Load<T>(assetName);
		}

		// Helper variables for hard coded names.
		private const String FONT_NAME = "Emulogic";
		private const String SPLASH_NAME = "StevePro";
		//private const String SPLASH_NAME = "Splash";		// TODO change
		private const String SPRITE_NAME = "Spritesheet";
		private const String TITLE_MUSIC_NAME = "TitleMusic";
		private const String GAME_OVER_NAME = "GameOver";
	}
}