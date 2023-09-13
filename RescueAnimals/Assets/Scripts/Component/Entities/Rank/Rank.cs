using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Rank : IComparable<Rank>
{
    public int Score { get; set; }
    public int StageNumber { get; set; }

    public Rank(int score, int stageNumber)
    {
        Score = score;
        StageNumber = stageNumber;
    }

    public int CompareTo(Rank other)
    {
        if (Score != other.Score)
        {
            return other.Score.CompareTo(Score); // ������ ���� ������ ����
        }
        return StageNumber.CompareTo(other.StageNumber); // ������ ������ �������� ��ȣ�� ����
    }
}
