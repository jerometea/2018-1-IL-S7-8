using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.Work
{
    public class YesWeCan
    {
        EngineState _state;

        public void Work()
        {
            Console.WriteLine( "Hello" );
            _state = _state.StartEngine();
        }
    }
}
