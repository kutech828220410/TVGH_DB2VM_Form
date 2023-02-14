using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using MyUI;
using Basic;
using System.Text.Json;
namespace DB2VM_Form
{
    public partial class Form1 : Form
    {
        public enum enum_UDSDBBCM
        {
            GUID,
            藥品碼,
            藥品名稱,
            料號,
            ATC主碼, 
            藥品條碼1,
            藥品條碼2,
            藥品條碼3,
            藥品條碼4,
            藥品條碼5,
        }
        public class MedClass
        {
            private string _藥品碼 = "";
            private string _藥品名稱 = "";
            private string _料號 = "";
            private string _ATC主碼 = "";
            private string _藥品條碼1 = "";
            private string _藥品條碼2 = "";
            private string _藥品條碼3 = "";
            private string _藥品條碼4 = "";
            private string _藥品條碼5 = "";

            public string 藥品碼 { get => _藥品碼; set => _藥品碼 = value; }
            public string 藥品名稱 { get => _藥品名稱; set => _藥品名稱 = value; }
            public string 料號 { get => _料號; set => _料號 = value; }
            public string ATC主碼 { get => _ATC主碼; set => _ATC主碼 = value; }
            public string 藥品條碼1 { get => _藥品條碼1; set => _藥品條碼1 = value; }
            public string 藥品條碼2 { get => _藥品條碼2; set => _藥品條碼2 = value; }
            public string 藥品條碼3 { get => _藥品條碼3; set => _藥品條碼3 = value; }
            public string 藥品條碼4 { get => _藥品條碼4; set => _藥品條碼4 = value; }
            public string 藥品條碼5 { get => _藥品條碼5; set => _藥品條碼5 = value; }
        }

        private void Program_UDSDBBCM_Init()
        {
            this.sqL_DataGridView_UDSDBBCM.Init();
            if (!this.sqL_DataGridView_UDSDBBCM.SQL_IsTableCreat()) this.sqL_DataGridView_UDSDBBCM.SQL_CreateTable();
            this.plC_RJ_Button_UDSDBBCM_Get.MouseDownEvent += PlC_RJ_Button_UDSDBBCM_Get_MouseDownEvent;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.MouseDownEvent += PlC_RJ_Button_USDSBBCM_表單_顯示全部_MouseDownEvent;

            this.plC_UI_Init1.Add_Method(this.Program_UDSDBBCM);
        }



        private void Program_UDSDBBCM()
        {
            sub_Program_UDSDBBCM_更新();
        }
        #region PLC_UDSDBBCM_更新
        PLC_Device PLC_Device_UDSDBBCM_更新 = new PLC_Device("");
        PLC_Device PLC_Device_UDSDBBCM_更新_OK = new PLC_Device("");
        MyTimer MyTimer_UDSDBBCM_更新_結束延遲 = new MyTimer();
        int cnt_Program_UDSDBBCM_更新 = 65534;
        Task Task_UDSDBBCM;
        void sub_Program_UDSDBBCM_更新()
        {
            PLC_Device_UDSDBBCM_更新.Bool = true;
            if (cnt_Program_UDSDBBCM_更新 == 65534)
            {
                this.MyTimer_UDSDBBCM_更新_結束延遲.StartTickTime(1000);
                PLC_Device_UDSDBBCM_更新.SetComment("PLC_UDSDBBCM_更新");
                PLC_Device_UDSDBBCM_更新_OK.SetComment("PLC_UDSDBBCM_更新_OK");
                PLC_Device_UDSDBBCM_更新.Bool = false;
                cnt_Program_UDSDBBCM_更新 = 65535;
            }
            if (cnt_Program_UDSDBBCM_更新 == 65535) cnt_Program_UDSDBBCM_更新 = 1;
            if (cnt_Program_UDSDBBCM_更新 == 1) cnt_Program_UDSDBBCM_更新_檢查按下(ref cnt_Program_UDSDBBCM_更新);
            if (cnt_Program_UDSDBBCM_更新 == 2) cnt_Program_UDSDBBCM_更新_初始化(ref cnt_Program_UDSDBBCM_更新);
            if (cnt_Program_UDSDBBCM_更新 == 3) cnt_Program_UDSDBBCM_更新 = 65500;
            if (cnt_Program_UDSDBBCM_更新 > 1) cnt_Program_UDSDBBCM_更新_檢查放開(ref cnt_Program_UDSDBBCM_更新);

            if (cnt_Program_UDSDBBCM_更新 == 65500)
            {
                this.MyTimer_UDSDBBCM_更新_結束延遲.TickStop();
                this.MyTimer_UDSDBBCM_更新_結束延遲.StartTickTime(60000);
                PLC_Device_UDSDBBCM_更新.Bool = false;
                PLC_Device_UDSDBBCM_更新_OK.Bool = false;
                cnt_Program_UDSDBBCM_更新 = 65535;
            }
        }
        void cnt_Program_UDSDBBCM_更新_檢查按下(ref int cnt)
        {
            if (PLC_Device_UDSDBBCM_更新.Bool) cnt++;
        }
        void cnt_Program_UDSDBBCM_更新_檢查放開(ref int cnt)
        {
            if (!PLC_Device_UDSDBBCM_更新.Bool) cnt = 65500;
        }
        void cnt_Program_UDSDBBCM_更新_初始化(ref int cnt)
        {
            if (this.MyTimer_UDSDBBCM_更新_結束延遲.IsTimeOut())
            {

                if (Task_UDSDBBCM == null)
                {
                    Task_UDSDBBCM = new Task(new Action(delegate { PlC_RJ_Button_UDSDBBCM_Get_MouseDownEvent(null); }));
                }
                if (Task_UDSDBBCM.Status == TaskStatus.RanToCompletion)
                {
                    Task_UDSDBBCM = new Task(new Action(delegate { PlC_RJ_Button_UDSDBBCM_Get_MouseDownEvent(null); }));
                }
                if (Task_UDSDBBCM.Status == TaskStatus.Created)
                {                
                    Task_UDSDBBCM.Start();
                }
                cnt++;
            }
        }







        #endregion
        #region Event
        private void PlC_RJ_Button_USDSBBCM_表單_顯示全部_MouseDownEvent(MouseEventArgs mevent)
        {
            this.sqL_DataGridView_UDSDBBCM.SQL_GetAllRows(true);
        }
        private void PlC_RJ_Button_UDSDBBCM_Get_MouseDownEvent(MouseEventArgs mevent)
        {
            try
            {
                rJ_TextBox_UDSDBBCM_API_URL.Text = "https://10.97.241.193:4433/api/UDSDBBCM";
                MyTimer myTimer = new MyTimer();
                myTimer.TickStop();
                myTimer.StartTickTime(5000);
                this.Invoke(new Action(delegate
                {
                    this.richTextBox_UDSDBBCM_API_GET.Text = "";
                }));
                Console.Write($"開始取得API {rJ_TextBox_UDSDBBCM_API_URL.Text}\n");
                string text = Basic.Net.WEBApiGet(rJ_TextBox_UDSDBBCM_API_URL.Texts);
                Console.Write($"{rJ_TextBox_UDSDBBCM_API_URL.Texts} : Get , 耗時 : {myTimer.ToString()}\n");
                List<MedClass> list_MedClass = JsonSerializer.Deserialize<List<MedClass>>(text);
                Console.Write($"JsonSerializer.Deserialize : Get , 耗時 : {myTimer.ToString()}\n");


                this.Invoke(new Action(delegate
                {
                    this.richTextBox_UDSDBBCM_API_GET.Text = text;
                }));
                Console.Write($"取得SQL UDSDBBCM 資料 : Get , 耗時 : {myTimer.ToString()}\n");
                List<object[]> list_UDSDBBCM = this.sqL_DataGridView_UDSDBBCM.SQL_GetAllRows(false);
                List<object[]> list_UDSDBBCM_buf = new List<object[]>();
                List<object[]> list_UDSDBBCM_Add = new List<object[]>();
                List<object[]> list_UDSDBBCM_Replace = new List<object[]>();
                for(int i = 0; i < list_MedClass.Count; i++)
                {
                    list_UDSDBBCM_buf = list_UDSDBBCM.GetRows((int)enum_UDSDBBCM.藥品碼, list_MedClass[i].藥品碼);
                    object[] value = new object[new enum_UDSDBBCM().GetLength()];
                    value[(int)enum_UDSDBBCM.GUID] = Guid.NewGuid().ToString();
                    value[(int)enum_UDSDBBCM.藥品碼] = list_MedClass[i].藥品碼;
                    value[(int)enum_UDSDBBCM.藥品名稱] = list_MedClass[i].藥品名稱;
                    value[(int)enum_UDSDBBCM.ATC主碼] = list_MedClass[i].ATC主碼;
                    value[(int)enum_UDSDBBCM.料號] = list_MedClass[i].料號;
                    value[(int)enum_UDSDBBCM.藥品條碼1] = list_MedClass[i].藥品條碼1;
                    value[(int)enum_UDSDBBCM.藥品條碼2] = list_MedClass[i].藥品條碼2;
                    value[(int)enum_UDSDBBCM.藥品條碼3] = list_MedClass[i].藥品條碼3;
                    value[(int)enum_UDSDBBCM.藥品條碼4] = list_MedClass[i].藥品條碼4;
                    value[(int)enum_UDSDBBCM.藥品條碼5] = list_MedClass[i].藥品條碼5;

                    if (list_UDSDBBCM_buf.Count == 0)
                    {
            
                        list_UDSDBBCM_Add.Add(value);
                    }
                    else
                    {
                        bool replace = false;
                        for(int k = 1; k < list_UDSDBBCM_buf[0].Length; k++)
                        {
                            if (list_UDSDBBCM_buf[0][k].ObjectToString() != value[k].ObjectToString())
                            {
                                replace = true;
                            }
                            list_UDSDBBCM_buf[0][k] = value[k];
                        }
                        if (replace) list_UDSDBBCM_Replace.Add(list_UDSDBBCM_buf[0]);
                    }
                }
                Console.Write($"計算 UDSDBBCM 資料 : Get , 耗時 : {myTimer.ToString()}\n");
                this.sqL_DataGridView_UDSDBBCM.SQL_AddRows(list_UDSDBBCM_Add, false);
                this.sqL_DataGridView_UDSDBBCM.SQL_ReplaceExtra(list_UDSDBBCM_Replace, false);
                Console.Write($"上傳SQL UDSDBBCM 新增資料{list_UDSDBBCM_Add.Count}筆 ,更新資料{list_UDSDBBCM_Replace.Count}筆 : Get , 耗時 : {myTimer.ToString()}\n");

            }
            catch
            {

            }
        }
        #endregion
    }
}
