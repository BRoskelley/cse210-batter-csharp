using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp
{
    /// <summary>
    /// An action to move all of the actors with a velocity in the game.
    /// </summary>
    public class MoveActorsAction :Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    MoveActor(actor);
                }
            }
        }
        private void MoveActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            int newX = (x + dx) % Constants.MAX_X;
            int newY = (y + dy) % Constants.MAX_Y;

            // if (newX < 0)
            // {
            //     newX = Constants.MAX_X;
            // }

            // if (newY < 0)
            // {
            //     newY = Constants.MAX_Y;
            // }

            actor.SetPosition(new Point(newX, newY));
        }
    }
}