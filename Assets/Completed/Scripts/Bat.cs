using UnityEngine;
using System.Collections;

namespace Completed {
    public class Bat : Enemy
    {
        //Overriding the AttemptMove function of the parent (Enemy) so that it moves every turn rather than every two.
        protected override void AttemptMove<T>(int xDir, int yDir)
        {
            //telling parent not to skip move
            setSkipMove(false);
            //Call the AttemptMove function from MovingObject.
            base.AttemptMove<T>(xDir, yDir);
        }

    }
}
