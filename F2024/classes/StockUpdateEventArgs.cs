using System;

namespace Classes{

    public class StockUpdateEventArgs : EventArgs
    {
        public string ShareName { get; set; }
        public float Value { get; set; }
        public DateTime Time { get; set; }

        public StockUpdateEventArgs(string shareName, float value, DateTime time)
        {
            ShareName = shareName;
            Value = value;
            Time = time;
        }
    }
}