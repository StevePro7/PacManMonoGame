using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame.Common.Static
{
	public static class Assets
	{
		// Fonts.
		public static SpriteFont EmulogicFont;
		public static SpriteFont MenuItem;
		public static SpriteFont Score;
		public static SpriteFont ScoreEvent;

		// Textures.
		public static Texture2D SplashTexture;
		public static Texture2D SpritesheetTexture;

		// Bonus.
		public static Texture2D AppleTexture;
		public static Texture2D BananaTexture;
		public static Texture2D BellTexture;
		public static Texture2D CherryTexture;
		public static Texture2D KeyTexture;
		public static Texture2D OrangeTexture;
		public static Texture2D PearTexture;
		public static Texture2D PretzelTexture;
		public static Texture2D StrawberryTexture;

		// Sprites
		public static Texture2D BoardTexture;
		public static Texture2D BoardFlashTexture;
		public static Texture2D CrumpTexture;
		public static Texture2D DyingSheetNewTexture;
		public static Texture2D ExtraLifeTexture;
		public static Texture2D GhostBaseTexture;
		public static Texture2D GhostBase2Texture;
		public static Texture2D GhostChasedTexture;
		public static Texture2D GhostEyesTexture;
		public static Texture2D GhostEyesCenterTexture;
		public static Texture2D PacManEating1Texture;
		public static Texture2D PacManEating2Texture;
		public static Texture2D PacManEating3Texture;
		public static Texture2D PacManEating4Texture;
		public static Texture2D PacManEating5Texture;
		public static Texture2D PacManEating6Texture;
		public static Texture2D PacManEating7Texture;
		public static Texture2D PacManEating8Texture;
		public static Texture2D PacManEating9Texture;
		public static Texture2D PowerPillTexture;
		public static Texture2D SelectionTexture;
		public static Texture2D TitleTexture;


		// Sound.
		public static IDictionary<SoundEffectType, SoundEffectInstance> SoundEffectDictionary;
		public static IDictionary<SoundEffectType2, SoundEffectInstance> SoundEffectDictionary2;
		public static Song TitleMusicSong;
		public static Song GameOverSong;
	}
}