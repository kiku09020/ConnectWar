using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    /// <summary>
    /// ���s
    /// </summary>
    void Execute();

    /// <summary>
    /// Excute()�̋t�̂��Ƃ��s��
    /// </summary>
    void Undo();
}

namespace Example {
    class ExampleCommand : ICommand {
        int num;

        public void Execute()
        {
            num++;
        }

        public void Undo()
        {
            num--;
        }
    }
}