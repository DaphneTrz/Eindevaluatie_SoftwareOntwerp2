using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Input
{
    public interface IPlayerInputService
    {
        public bool MoveUp();
        public bool MoveDown();
        public bool MoveLeft();
        public bool MoveRight();

    }
}
