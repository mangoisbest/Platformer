using UnityEngine;

namespace Platformer.Mechanics
{
    
    /// This component is used to create a patrol path, two points which enemies will move between.
    public partial class PatrolPath : MonoBehaviour
    {
        
        /// One end of the patrol path.
        public Vector2 startPosition, endPosition;

        /// Create a Mover instance which is used to move an entity along the path at a certain speed.
        public Mover CreateMover(float speed = 1) => new Mover(this, speed);

        void Reset()
        {
            startPosition = Vector3.left;
            endPosition = Vector3.right;
        }
    }
}