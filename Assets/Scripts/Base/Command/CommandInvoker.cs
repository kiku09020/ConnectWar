using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �R�}���h���Ăяo���N���X
/// </summary>
public class CommandInvoker : MonoBehaviour
{
    /* stocks */
    static Stack<ICommand> undoStack = new Stack<ICommand>();
    static Stack<ICommand> redoStack = new Stack<ICommand>();

    /// <summary>
    /// �R�}���h�����s����
    /// </summary>
    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();              // �R�}���h���s
                                        
        undoStack.Push(command);        // �R�}���h��undoStack�ɒǉ�
        redoStack.Clear();              // redoStack�̗v�f���폜
    }

    /// <summary>
    /// �߂�
    /// </summary>
    public static void UndoCommand()
    {
        if (undoStack.Count > 0) {
            var activeCommand = undoStack.Pop();        // undoStack������o��
            redoStack.Push(activeCommand);              // ���o�����R�}���h��redoStack�ɒǉ�
                                                        
            activeCommand.Undo();                       // �߂�
        }
    }

    /// <summary>
    /// �i��
    /// </summary>
    public static void RedoCommand()
    {
        if (redoStack.Count > 0) {
            var activeCommand = redoStack.Pop();        // redoStack������o��
            undoStack.Push(activeCommand);              // ���o�����R�}���h��undoStack�ɒǉ�
                                                        
            activeCommand.Execute();                    // ���s
        }
    }
}
