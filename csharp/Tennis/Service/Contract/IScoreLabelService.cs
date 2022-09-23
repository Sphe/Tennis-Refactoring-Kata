using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Domain;

namespace Tennis.Service.Contract
{
    public interface IScoreLabelService
    {

        string Create(Player player1, Player player2);

    }
}
