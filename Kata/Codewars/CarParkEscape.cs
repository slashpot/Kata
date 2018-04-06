using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class CarParkEscape
    {
        private readonly List<string> _finalRoute = new List<string>();
        private int _currentFloors;
        private int _floors;
        private int[,] _carpark;
        private int _floorLength;

        public string[] Escape(int[,] carpark)
        {
            Init(carpark);
            FindStairOrExit(GetStartPos());
            return _finalRoute.ToArray();
        }

        private void Init(int[,] carpark)
        {
            _carpark = carpark;
            _floors = _carpark.GetLength(0);
            _floorLength = _carpark.GetLength(1);
        }

        private int GetStartPos()
        {
            for (int i = 0; i < _floors; i++)
            {
                var pos = GetIndex(i, (int)CarParkType.Start);
                if (pos != -1)
                {
                    return pos;
                }
                _currentFloors++;
            }
            throw new Exception("get start pos fail");
        }

        private int GetIndex(int floor, int target)
        {
            return Enumerable.Range(0, _floorLength).Select(x => _carpark[floor, x]).ToList().IndexOf(target);
        }

        private void FindStairOrExit(int pos)
        {
            if (IsLastFloor())
            {
                GoToExit(pos);
            }
            else
            {
                var stair = GoToStair(pos);
                GoDownStairs(stair);
                FindStairOrExit(stair);
            }
        }

        private void GoDownStairs(int stair)
        {
            var downstairs = 0;
            while (_carpark[_currentFloors, stair] == (int)CarParkType.Stair && _currentFloors != _floors - 1)
            {
                downstairs++;
                _currentFloors++;
            }
            _finalRoute.Add("D" + downstairs);
        }

        private int GoToStair(int pos)
        {
            var stair = GetIndex(_currentFloors, (int)CarParkType.Stair);
            var distance = Math.Abs(pos - stair);
            var direction = pos > stair ? "L" : "R";

            _finalRoute.Add(direction + distance);
            return stair;
        }

        private void GoToExit(int pos)
        {
            var indexOfExit = _floorLength - 1;
            if (pos == indexOfExit) return;
            var distance = indexOfExit - pos;
            _finalRoute.Add("R" + distance);
        }

        private bool IsLastFloor()
        {
            return _currentFloors == _floors - 1;
        }
    }

    public enum CarParkType
    {
        Stair = 1,
        Start = 2
    }
}