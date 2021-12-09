using System;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Paddle :Actor
    {
        public Paddle()
        {
            SetImage(Constants.IMAGE_PADDLE);
            SetWidth(Constants.PADDLE_WIDTH);
            SetHeight(Constants.PADDLE_WIDTH);
            SetPosition(_position);
        }
    }
}