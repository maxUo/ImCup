using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.Interfaces {
        public interface IAudio {
            int PlayMp3File( string fileName );
            void StopPlay(int ID);
        }

}
