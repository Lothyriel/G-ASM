using Domain.GameEngine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object = Domain.GameEngine.Objects.Object;

namespace Domain.GameEngine.Physics
{
    public class PhysicsEngine
    {
        public PhysicsEngine(List<Object> objects)
        {
            Objects = objects;
        }

        public List<Object> Objects { get; }

        public void Simulate(MovingObject mObj)
        {
            foreach (var obj in Objects)
            {
                if (obj == mObj)
                    continue;

                var hitDirection = mObj.Hit(obj);

                if (hitDirection is HitDirection.None)
                    continue;

                TreatCollision(mObj, obj, hitDirection);
            }
        }

        private static void TreatCollision(MovingObject mObj, Object obj, HitDirection hitDirection)
        {
            switch (hitDirection)
            {
                case HitDirection.Right:
                case HitDirection.Left:
                    mObj.YSpeed *= -1;
                    break;

                case HitDirection.Top:
                case HitDirection.Bottom:
                    mObj.XSpeed *= -1;
                    break;

                default: throw new ArgumentException("Invalid Hit Direction");
            }
        }
    }
}
