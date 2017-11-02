using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Shape
    {
        private Point pivot;

        private void LogDrawing(Logger logger)
        {
            var msg =
                String.Format("The new shape is drawn at {0}, {1}",
                    pivot.X, pivot.Y);
            logger.Log(msg);
        }
    }

    internal class Point
    {
        public object X { get; set; }
        public object Y { get; set; }
    }

    class Logger
    {
        public void Log(string msg)
        {
            // log the message
        }
    }
}
