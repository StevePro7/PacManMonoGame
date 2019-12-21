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

		// Sound.
		public static IDictionary<SoundEffectType, SoundEffectInstance> SoundEffectDictionary;
		public static IDictionary<SoundEffectType2, SoundEffectInstance> SoundEffectDictionary2;
		public static Song TitleMusicSong;
		public static Song GameOverSong;
	}
}