using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    interface ILogic<TDTO>
    {
        void Create(TDTO item);
        TDTO Read(Guid Id);
        void Update(TDTO item);
        void Delete(Guid Id);
    }
}
