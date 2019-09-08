using System;
using System.Collections.Generic;

namespace Core
{
   public class Res
    {
            public Res(bool isDone, string message, IEnumerable<object> data)
            {
                IsDone = isDone;
                Message = message;
                Data = data;
                ResponseTime = DateTime.Now;
            }

            public Res(bool isDone, string message, object data)
            {
                IsDone = isDone;
                Message = message;
                Data = new List<object> { data };
                ResponseTime = DateTime.Now;
            }

            public bool IsDone { get; set; }
            public string Message { get; set; }
            public IEnumerable<object> Data { get; set; }
            public DateTime ResponseTime { get; set; }
        }
    }

