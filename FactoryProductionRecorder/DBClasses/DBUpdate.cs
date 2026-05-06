using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCode;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DBClasses
{
    class DBUpdate
    {
        public static bool Update_BayLine_OfSelectedData(ref string[] queries, string PhaseId, string AssmPos, string NewAssmPos, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   ASSMPOS = '" + NewAssmPos + @"'
                                                                                WHERE  [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND ('" + TheRefMak + "' IN (REFID, ID))";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_AssmPos_OfSelectedData(ref string[] queries, string PhaseId, string AssmPos, string NewAssmPos, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   ASSMPOS = '" + NewAssmPos + @"'
                                                                                WHERE  [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND ('" + TheRefMak + "' IN (REFID, ID))";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_Lock_ForTheSelectedData(ref string[] queries, string PhaseId, string AssmPos, string UpdateLock,  string FilterLock, string PrevStatus, string TransBy, string TransOn, string TheRefMak, string TheShift)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   THELOCK = '" + UpdateLock + @"',
                                                                                TRANSFEREDBY = '" + TransBy + @"', 
                                                                                TRANSFEREDON = " + TransOn + @", 
                                                                                [SHIFT] = " + Cart.ValidateNullvalue(TheShift, true) + @"
                                                                       WHERE [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND [STATUS] = '" + PrevStatus + 
                                                                                "' AND [THELOCK] = '" + FilterLock + 
                                                                                "' AND [REFID] = '" + TheRefMak + "'";


                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_Lock_ForTheSelectedData_IDBased(ref string[] queries, string PhaseId, string AssmPos, string UpdateLock, string FilterLock, string PrevStatus, string TransBy, string TransOn, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   THELOCK = '" + UpdateLock + @"',
                                                                                TRANSFEREDBY = '" + TransBy + @"', 
                                                                                TRANSFEREDON = " + TransOn + @"
                                                                       WHERE [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND [STATUS] = '" + PrevStatus +
                                                                                "' AND [THELOCK] = '" + FilterLock +
                                                                                "' AND [ID] = '" + TheRefMak + "'";


                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_Lock_ForTheSelectedData_WithId(ref string[] queries, string PhaseId, string AssmPos, string UpdateLock, string FilterLock, string FilterStatus, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   THELOCK = '" + UpdateLock + @"'
                                                                       WHERE [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND [STATUS] = '" + FilterStatus +
                                                                                "' AND [THELOCK] = '" + FilterLock +
                                                                                "' AND [REFID]  = " + TheRefMak;


                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData_WithOutId " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_Lock_ForTheSelectedData_WithOutId(ref string[] queries, string PhaseId, string AssmPos, string UpdateLock, string FilterLock, string FilterStatus, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET   THELOCK = '" + UpdateLock + @"'
                                                                       WHERE [PHASEID] = '" + PhaseId +
                                                                                "' AND [ASSMPOS] = '" + AssmPos +
                                                                                "' AND [STATUS] = '" + FilterStatus +
                                                                                "' AND [THELOCK] = '" + FilterLock +
                                                                                "' AND [ID]  = " + TheRefMak;


                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_Lock_ForTheSelectedData_WithOutId " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }


        public static bool Update_DataAsHold(ref string[] queries, string PhaseId, string AssmPos, string PrevStatus, string CurLock, string NewLock, string refID)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records SET THELOCK = '" + NewLock + "'" +
                                                                " where [PHASEID] = '" + PhaseId + "' AND [ASSMPOS] = '" + AssmPos + "' AND [STATUS] = '" + PrevStatus + "' AND [THELOCK] = '" + CurLock + "' AND [REFID] = '" + refID + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_DataAsHold " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Update_StatusInfo_ForTheSelectedData(ref string[] queries, string PhaseId, string AssmPos, string TransBy, string TransOn, string CurStatus, string NewStatus, string CurLock, string NewLock, string TheRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);


                queries[queries.Length - 1] = @"UPDATE ProdStatus_Records
                                                SET 
                                                    [STATUS] = '" + NewStatus + @"',
                                                    TRANSFEREDBY = '" + TransBy + @"',
                                                    TRANSFEREDON = " + TransOn + @",
                                                    THELOCK = '" + NewLock + @"',
                                                    REFID = CASE 
                                                                WHEN REFID = 0 THEN ID 
                                                                ELSE REFID 
                                                            END
                                                    where [PHASEID] = '" + PhaseId + @"'
                                                     AND [ASSMPOS] = '" + AssmPos + @"'
                                                     AND [STATUS] = '" + CurStatus + @"'
                                                     AND [THELOCK] = '" + CurLock + @"'
                                                     AND [REFID] = '" + TheRefMak + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Update_StatusInfo_ForTheSelectedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Delete_TranferedData_WithOutID(ref string[] queries, string PhaseId, string AssmPos, string CurStatus, string TheCurLock, string NewStatus, string TheNextLock)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"DELETE FROM ProdStatus_Records
                                                        WHERE
                                                             [PHASEID] = '" + PhaseId + @"'
                                                          AND[ASSMPOS] = '" + AssmPos + @"'
                                                          AND[STATUS] = '" + NewStatus + @"'
                                                          AND[THELOCK] = '" + TheNextLock + @"'
                                                          AND[REFID] IN (SELECT PR.ID FROM ProdStatus_Records AS PR WHERE
                                                                PR.[PHASEID] = '" + PhaseId + @"'
                                                                AND PR.[ASSMPOS] = '" + AssmPos + @"'
                                                                AND PR.[STATUS] = '" + CurStatus + @"'
                                                                AND PR.[THELOCK] = '" + TheCurLock + "')";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Delete_TranferedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Delete_TranferedData(ref string[] queries, string PhaseId, string AssmPos, string NewStatus, string TheNextLock, string TheRefId)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"DELETE FROM ProdStatus_Records where [PHASEID] = '" + PhaseId + "' AND [ASSMPOS] = '" + AssmPos + "' AND [STATUS] = '" + NewStatus + "' AND [THELOCK] = '" + TheNextLock + "' AND [REFID] = '" + TheRefId + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Delete_TranferedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Delete_TranferedData(ref string[] queries, string PhaseId, string AssmPos, string NewStatus, string TheRefId)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"DELETE FROM ProdStatus_Records where [PHASEID] = '" + PhaseId +
                    "' AND [ASSMPOS] = '" + AssmPos + 
                    "' AND [STATUS] = '" + NewStatus + 
                    "' AND [THELOCK] in ('O','P','L') AND ([REFID] = '" + TheRefId + "' OR [ID] = '" + TheRefId + "')";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Delete_TranferedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Delete_Existing_Records(ref string[] queries, string thephaseid, string theAssmMak, string thestatus, string thelock)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"DELETE FROM ProdStatus_Records where PHASEID like '" + thephaseid +
                                                                                "' and ASSMPOS   = '" + theAssmMak +
                                                                                "' and STATUS   = '" + thestatus +
                                                                                "' and THELOCK  = '" + thelock + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Delete_Existing_Records " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }
        
        public static bool Delete_Existing_Records(ref string[] queries, string thephaseid, string theAssmMak, string thestatus, string thelock, string refid)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"DELETE FROM ProdStatus_Records where PHASEID like '" + thephaseid +
                                                                               "' and ASSMPOS   = '" + theAssmMak +
                                                                               "' and STATUS   = '" + thestatus +
                                                                               "' and THELOCK  = '" + thelock +
                                                                               "' and REFID  = '" + refid + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Delete_Existing_Records " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }


    }
}
