using System;

namespace cse210_batter_csharp.Casting
{
    public class Ball : Actor
    {

        public Ball()
        {
            SetImage(Constants.IMAGE_BALL);
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetPosition(_position);
            
        }

    }
}