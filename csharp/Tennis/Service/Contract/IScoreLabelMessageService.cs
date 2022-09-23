using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Service.Contract
{
    public interface IScoreLabelMessageService
    {

        string LabelWinningScoreList(int diffScorePoint);

        string LabelEqualScoreList(int index);

        string LabelNormalScoreList(int index);

    }
}
