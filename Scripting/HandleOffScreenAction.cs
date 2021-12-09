using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();

        public HandleOffScreenAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0]; // There is only one

            if (ball.GetRightEdge() >= Constants.MAX_X)
            {
                ball.SetVelocity(new Point(ball.GetVelocity().GetX()*-1, ball.GetVelocity().GetY()));
            }
            if (ball.GetLeftEdge() <= 0)
            {
                ball.SetVelocity(new Point(ball.GetVelocity().GetX()*-1, ball.GetVelocity().GetY()));
            }
            if (ball.GetTopEdge() <= 0)
            {
                ball.SetVelocity(new Point(ball.GetVelocity().GetX(), ball.GetVelocity().GetY()*-1));
            }   
            if (ball.GetBottomEdge() >= Constants.MAX_Y)
            {
                ball.SetVelocity(new Point(ball.GetVelocity().GetX(), ball.GetVelocity().GetY()*-1));
            }                           
        }
    }
}