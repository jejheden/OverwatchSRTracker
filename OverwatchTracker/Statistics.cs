using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchTracker
{
    public class Statistics
    {
        private List<decimal> _list;
        private DataGridView _dgv;

        public Statistics(DataGridView dgvData)
        {

            _dgv = dgvData;
        }

        private void AddValue(decimal value)
        {
            _list.Add(value);
        }

        private string GetAverage(int DecimalPoints)
        {
            string result = "-";
            decimal decResult;

            if (_list.Count > 0)
            {
                decResult = _list.Average();
                result = Math.Round(decResult, DecimalPoints).ToString();
            }

            return result;
        }

        private string GetSum()
        {
            string result = "-";
            decimal decResult;

            if (_list.Count > 0)
            {
                decResult = _list.Sum();
                result = decResult.ToString();
            }

            return result;
        }

        public string GetHeroAverage(string Hero, string DataColumnName, string Queue, DateTime FromDate, DateTime ToDate, string Condition, int DecimalPoints)
        {

            _list = new List<decimal>();

            foreach (DataGridViewRow dgvRow in _dgv.Rows)
            {
                if (dgvRow.IsNewRow)
                {
                    continue;
                }
                if (Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date >= FromDate.Date &&
                Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date <= ToDate.Date)
                {
                    try
                    {
                        if (dgvRow.Cells[DataColumnName].Value.ToString() == Hero && dgvRow.Cells["WinLoss"].Value.ToString() == Condition)
                        {
                            if (Queue == "All")
                            {
                                AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                            }
                            else
                            {
                                if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                {
                                    AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
            }
            return GetAverage(DecimalPoints);
        }

        public string GetOverallStats(string Operation, string Condition, string Queue, DateTime FromDate, DateTime ToDate, int DecimalPoints)
        {
            try
            {
                _list = new List<decimal>();

                foreach (DataGridViewRow dgvRow in _dgv.Rows)
                {
                    if (dgvRow.IsNewRow)
                    {
                        continue;
                    }
                    if (Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date >= FromDate.Date &&
                    Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date <= ToDate.Date)
                    {
                        try
                        {
                            switch (Condition)
                            {
                                case "Victory":
                                    if (dgvRow.Cells["WinLoss"].Value.ToString() == "Victory")
                                    {
                                        if (Queue == "All")
                                        {
                                            AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                        }
                                        else
                                        {
                                            if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                            {
                                                AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                            }
                                        }
                                    }
                                    break;
                                case "Defeat":
                                    if (dgvRow.Cells["WinLoss"].Value.ToString() == "Defeat")
                                    {
                                        if (Queue == "All")
                                        {
                                            AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                        }
                                        else
                                        {
                                            if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                            {
                                                AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                            }
                                        }
                                    }
                                    break;
                                case "Overall":
                                    if (Queue == "All")
                                    {
                                        AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                    }
                                    else
                                    {
                                        if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                        {
                                            AddValue(decimal.Parse(dgvRow.Cells["SRChange"].Value.ToString()));
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                switch (Operation)
                {
                    case "Average":
                        return GetAverage(DecimalPoints);
                    case "Sum":
                        return GetSum();
                    default:
                        return "-";
                }
            }
            catch (Exception)
            {
                return "-";
            }
        }

        public string GetGamesPlayed(string Condition, string Queue, DateTime FromDate, DateTime ToDate)
        {
            string GamesPlayed = "-";
            int intGamesPlayed = 0;
            try
            {

                foreach (DataGridViewRow dgvRow in _dgv.Rows)
                {
                    if (dgvRow.IsNewRow)
                    {
                        continue;
                    }
                    if (Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date >= FromDate.Date &&
                    Convert.ToDateTime(dgvRow.Cells["MatchDate"].Value.ToString()).Date <= ToDate.Date)
                    {
                        //try
                        //{
                        //    if (Queue == "All")
                        //    {
                        //        intGamesPlayed++;
                        //    }
                        //    else
                        //    {
                        //        if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                        //        {
                        //            intGamesPlayed++;
                        //        }
                        //    }
                        //}
                        //catch (Exception)
                        //{
                        //}





                        switch (Condition)
                        {
                            case "Victory":
                                if (dgvRow.Cells["WinLoss"].Value.ToString() == "Victory")
                                {
                                    if (Queue == "All")
                                    {
                                        intGamesPlayed++;
                                    }
                                    else
                                    {
                                        if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                        {
                                            intGamesPlayed++;
                                        }
                                    }
                                }
                                break;
                            case "Defeat":
                                if (dgvRow.Cells["WinLoss"].Value.ToString() == "Defeat")
                                {
                                    if (Queue == "All")
                                    {
                                        intGamesPlayed++;
                                    }
                                    else
                                    {
                                        if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                        {
                                            intGamesPlayed++;
                                        }
                                    }
                                }
                                break;
                            case "Overall":
                                if (Queue == "All")
                                {
                                    intGamesPlayed++;
                                }
                                else
                                {
                                    if (dgvRow.Cells["SoloTeam"].Value.ToString() == Queue)
                                    {
                                        intGamesPlayed++;
                                    }
                                }
                                break;
                            default:
                                break;
                        }







                    }
                }
                GamesPlayed = intGamesPlayed.ToString();
            }
            catch (Exception)
            {
                GamesPlayed = "-";
            }


            return GamesPlayed;
        }
    }
}
