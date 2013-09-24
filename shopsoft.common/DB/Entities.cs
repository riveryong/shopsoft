using System;
using DevExpress.Xpo;
namespace shopsoft.common.DB
{

    public class t_Operator_Info : XPLiteObject
    {
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        DateTime fCreate_DateTime;
        public DateTime Create_DateTime
        {
            get { return fCreate_DateTime; }
            set { SetPropertyValue<DateTime>("Create_DateTime", ref fCreate_DateTime, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fLogin_Error_Num;
        public int Login_Error_Num
        {
            get { return fLogin_Error_Num; }
            set { SetPropertyValue<int>("Login_Error_Num", ref fLogin_Error_Num, value); }
        }
        string fOperator_Action_Name;
        [Size(SizeAttribute.Unlimited)]
        public string Operator_Action_Name
        {
            get { return fOperator_Action_Name; }
            set { SetPropertyValue<string>("Operator_Action_Name", ref fOperator_Action_Name, value); }
        }
        string fOperator_Action_Right;
        [Size(SizeAttribute.Unlimited)]
        public string Operator_Action_Right
        {
            get { return fOperator_Action_Right; }
            set { SetPropertyValue<string>("Operator_Action_Right", ref fOperator_Action_Right, value); }
        }
        int fOperator_ID;
        [Key(true)]
        public int Operator_ID
        {
            get { return fOperator_ID; }
            set { SetPropertyValue<int>("Operator_ID", ref fOperator_ID, value); }
        }
        string fOperator_Menu_Name;
        [Size(SizeAttribute.Unlimited)]
        public string Operator_Menu_Name
        {
            get { return fOperator_Menu_Name; }
            set { SetPropertyValue<string>("Operator_Menu_Name", ref fOperator_Menu_Name, value); }
        }
        string fOperator_Menu_Right;
        [Size(SizeAttribute.Unlimited)]
        public string Operator_Menu_Right
        {
            get { return fOperator_Menu_Right; }
            set { SetPropertyValue<string>("Operator_Menu_Right", ref fOperator_Menu_Right, value); }
        }
        string fOperator_Model_Right;
        [Size(SizeAttribute.Unlimited)]
        public string Operator_Model_Right
        {
            get { return fOperator_Model_Right; }
            set { SetPropertyValue<string>("Operator_Model_Right", ref fOperator_Model_Right, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        string fOperator_Password;
        [Size(64)]
        public string Operator_Password
        {
            get { return fOperator_Password; }
            set { SetPropertyValue<string>("Operator_Password", ref fOperator_Password, value); }
        }
        int fOperator_State;
        public int Operator_State
        {
            get { return fOperator_State; }
            set { SetPropertyValue<int>("Operator_State", ref fOperator_State, value); }
        }
        int fOperator_Type;
        public int Operator_Type
        {
            get { return fOperator_Type; }
            set { SetPropertyValue<int>("Operator_Type", ref fOperator_Type, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        string fSys_Theme;
        [Size(30)]
        public string Sys_Theme
        {
            get { return fSys_Theme; }
            set { SetPropertyValue<string>("Sys_Theme", ref fSys_Theme, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        string fUpdate_Operator_No;
        [Size(50)]
        public string Update_Operator_No
        {
            get { return fUpdate_Operator_No; }
            set { SetPropertyValue<string>("Update_Operator_No", ref fUpdate_Operator_No, value); }
        }
        public t_Operator_Info(Session session) : base(session) { }
        public t_Operator_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Member_Charge_History : XPLiteObject
    {
        double fBalance;
        public double Balance
        {
            get { return fBalance; }
            set { SetPropertyValue<double>("Balance", ref fBalance, value); }
        }
        int fBonus;
        public int Bonus
        {
            get { return fBonus; }
            set { SetPropertyValue<int>("Bonus", ref fBonus, value); }
        }
        int fCharge_Bonus;
        public int Charge_Bonus
        {
            get { return fCharge_Bonus; }
            set { SetPropertyValue<int>("Charge_Bonus", ref fCharge_Bonus, value); }
        }
        DateTime fCharge_DateTime;
        public DateTime Charge_DateTime
        {
            get { return fCharge_DateTime; }
            set { SetPropertyValue<DateTime>("Charge_DateTime", ref fCharge_DateTime, value); }
        }
        int fCharge_Deal_Time;
        public int Charge_Deal_Time
        {
            get { return fCharge_Deal_Time; }
            set { SetPropertyValue<int>("Charge_Deal_Time", ref fCharge_Deal_Time, value); }
        }
        int fCharge_History_ID;
        [Key(true)]
        public int Charge_History_ID
        {
            get { return fCharge_History_ID; }
            set { SetPropertyValue<int>("Charge_History_ID", ref fCharge_History_ID, value); }
        }
        double fCharge_Money;
        public double Charge_Money
        {
            get { return fCharge_Money; }
            set { SetPropertyValue<double>("Charge_Money", ref fCharge_Money, value); }
        }
        int fCharge_UseTime;
        public int Charge_UseTime
        {
            get { return fCharge_UseTime; }
            set { SetPropertyValue<int>("Charge_UseTime", ref fCharge_UseTime, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        int fDeal_Time;
        public int Deal_Time
        {
            get { return fDeal_Time; }
            set { SetPropertyValue<int>("Deal_Time", ref fDeal_Time, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        t_Member_Info fMember_ID;
        public t_Member_Info Member_ID
        {
            get { return fMember_ID; }
            set { SetPropertyValue<t_Member_Info>("Member_ID", ref fMember_ID, value); }
        }
        string fMember_No;
        public string Member_No
        {
            get { return fMember_No; }
            set { SetPropertyValue<string>("Member_No", ref fMember_No, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fRemaining_Time;
        public int Remaining_Time
        {
            get { return fRemaining_Time; }
            set { SetPropertyValue<int>("Remaining_Time", ref fRemaining_Time, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        double fYingShouCash;
        public double YingShouCash
        {
            get { return fYingShouCash; }
            set { SetPropertyValue<double>("YingShouCash", ref fYingShouCash, value); }
        }
        public t_Member_Charge_History(Session session) : base(session) { }
        public t_Member_Charge_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Company_Info : XPLiteObject
    {
        int fCan_Send_Sms_Count;
        public int Can_Send_Sms_Count
        {
            get { return fCan_Send_Sms_Count; }
            set { SetPropertyValue<int>("Can_Send_Sms_Count", ref fCan_Send_Sms_Count, value); }
        }
        double fCompany_Balance;
        public double Company_Balance
        {
            get { return fCompany_Balance; }
            set { SetPropertyValue<double>("Company_Balance", ref fCompany_Balance, value); }
        }
        int fCompany_ID;
        [Key(true)]
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fCompany_Name;
        [Size(50)]
        public string Company_Name
        {
            get { return fCompany_Name; }
            set { SetPropertyValue<string>("Company_Name", ref fCompany_Name, value); }
        }
        string fCompany_No;
        public string Company_No
        {
            get { return fCompany_No; }
            set { SetPropertyValue<string>("Company_No", ref fCompany_No, value); }
        }
        int fCompany_Status;
        public int Company_Status
        {
            get { return fCompany_Status; }
            set { SetPropertyValue<int>("Company_Status", ref fCompany_Status, value); }
        }
        string fCustom_Property1_Name;
        [Size(50)]
        public string Custom_Property1_Name
        {
            get { return fCustom_Property1_Name; }
            set { SetPropertyValue<string>("Custom_Property1_Name", ref fCustom_Property1_Name, value); }
        }
        string fCustom_Property2_Name;
        [Size(50)]
        public string Custom_Property2_Name
        {
            get { return fCustom_Property2_Name; }
            set { SetPropertyValue<string>("Custom_Property2_Name", ref fCustom_Property2_Name, value); }
        }
        string fCustom_Property3_Name;
        [Size(50)]
        public string Custom_Property3_Name
        {
            get { return fCustom_Property3_Name; }
            set { SetPropertyValue<string>("Custom_Property3_Name", ref fCustom_Property3_Name, value); }
        }
        string fCustom_Property4_Name;
        [Size(50)]
        public string Custom_Property4_Name
        {
            get { return fCustom_Property4_Name; }
            set { SetPropertyValue<string>("Custom_Property4_Name", ref fCustom_Property4_Name, value); }
        }
        string fCustom_Property5_Name;
        [Size(50)]
        public string Custom_Property5_Name
        {
            get { return fCustom_Property5_Name; }
            set { SetPropertyValue<string>("Custom_Property5_Name", ref fCustom_Property5_Name, value); }
        }
        string fCustom_Property6_Name;
        [Size(50)]
        public string Custom_Property6_Name
        {
            get { return fCustom_Property6_Name; }
            set { SetPropertyValue<string>("Custom_Property6_Name", ref fCustom_Property6_Name, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        DateTime fDue_Datetime;
        public DateTime Due_Datetime
        {
            get { return fDue_Datetime; }
            set { SetPropertyValue<DateTime>("Due_Datetime", ref fDue_Datetime, value); }
        }
        string fLink_Man_Phone;
        [Size(50)]
        public string Link_Man_Phone
        {
            get { return fLink_Man_Phone; }
            set { SetPropertyValue<string>("Link_Man_Phone", ref fLink_Man_Phone, value); }
        }
        int fMax_MemberCount;
        public int Max_MemberCount
        {
            get { return fMax_MemberCount; }
            set { SetPropertyValue<int>("Max_MemberCount", ref fMax_MemberCount, value); }
        }
        int fRecord_State;
        public int Record_State
        {
            get { return fRecord_State; }
            set { SetPropertyValue<int>("Record_State", ref fRecord_State, value); }
        }
        string fSms_Template_AddMember;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_AddMember
        {
            get { return fSms_Template_AddMember; }
            set { SetPropertyValue<string>("Sms_Template_AddMember", ref fSms_Template_AddMember, value); }
        }
        string fSms_Template_Bonus_Money;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Bonus_Money
        {
            get { return fSms_Template_Bonus_Money; }
            set { SetPropertyValue<string>("Sms_Template_Bonus_Money", ref fSms_Template_Bonus_Money, value); }
        }
        string fSms_Template_Bonus_Product;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Bonus_Product
        {
            get { return fSms_Template_Bonus_Product; }
            set { SetPropertyValue<string>("Sms_Template_Bonus_Product", ref fSms_Template_Bonus_Product, value); }
        }
        string fSms_Template_Charge;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Charge
        {
            get { return fSms_Template_Charge; }
            set { SetPropertyValue<string>("Sms_Template_Charge", ref fSms_Template_Charge, value); }
        }
        string fSms_Template_Deal_Moeny;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Deal_Moeny
        {
            get { return fSms_Template_Deal_Moeny; }
            set { SetPropertyValue<string>("Sms_Template_Deal_Moeny", ref fSms_Template_Deal_Moeny, value); }
        }
        string fSms_Template_Deal_Product;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Deal_Product
        {
            get { return fSms_Template_Deal_Product; }
            set { SetPropertyValue<string>("Sms_Template_Deal_Product", ref fSms_Template_Deal_Product, value); }
        }
        string fSms_Template_Deal_Times;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Template_Deal_Times
        {
            get { return fSms_Template_Deal_Times; }
            set { SetPropertyValue<string>("Sms_Template_Deal_Times", ref fSms_Template_Deal_Times, value); }
        }
        string fSys_Version;
        public string Sys_Version
        {
            get { return fSys_Version; }
            set { SetPropertyValue<string>("Sys_Version", ref fSys_Version, value); }
        }
        int fSys_Version_Display_Order;
        public int Sys_Version_Display_Order
        {
            get { return fSys_Version_Display_Order; }
            set { SetPropertyValue<int>("Sys_Version_Display_Order", ref fSys_Version_Display_Order, value); }
        }
        int fSys_Version_ID;
        public int Sys_Version_ID
        {
            get { return fSys_Version_ID; }
            set { SetPropertyValue<int>("Sys_Version_ID", ref fSys_Version_ID, value); }
        }
        string fSystem_Show_Name;
        public string System_Show_Name
        {
            get { return fSystem_Show_Name; }
            set { SetPropertyValue<string>("System_Show_Name", ref fSystem_Show_Name, value); }
        }
        public t_Company_Info(Session session) : base(session) { }
        public t_Company_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_System_Info : XPLiteObject
    {
        string fAudioFile_Memory_Address;
        [Size(SizeAttribute.Unlimited)]
        public string AudioFile_Memory_Address
        {
            get { return fAudioFile_Memory_Address; }
            set { SetPropertyValue<string>("AudioFile_Memory_Address", ref fAudioFile_Memory_Address, value); }
        }
        DateTime fCall_History_Syn_Time;
        public DateTime Call_History_Syn_Time
        {
            get { return fCall_History_Syn_Time; }
            set { SetPropertyValue<DateTime>("Call_History_Syn_Time", ref fCall_History_Syn_Time, value); }
        }
        int fCan_Send_Sms_Count;
        public int Can_Send_Sms_Count
        {
            get { return fCan_Send_Sms_Count; }
            set { SetPropertyValue<int>("Can_Send_Sms_Count", ref fCan_Send_Sms_Count, value); }
        }
        string fCompany_No;
        [Size(20)]
        public string Company_No
        {
            get { return fCompany_No; }
            set { SetPropertyValue<string>("Company_No", ref fCompany_No, value); }
        }
        int fIS_Delete_Record;
        public int IS_Delete_Record
        {
            get { return fIS_Delete_Record; }
            set { SetPropertyValue<int>("IS_Delete_Record", ref fIS_Delete_Record, value); }
        }
        int fIS_Record;
        public int IS_Record
        {
            get { return fIS_Record; }
            set { SetPropertyValue<int>("IS_Record", ref fIS_Record, value); }
        }
        int fIs_Syn_To_Local_Net;
        public int Is_Syn_To_Local_Net
        {
            get { return fIs_Syn_To_Local_Net; }
            set { SetPropertyValue<int>("Is_Syn_To_Local_Net", ref fIs_Syn_To_Local_Net, value); }
        }
        int fIs_Syn_To_Yun;
        public int Is_Syn_To_Yun
        {
            get { return fIs_Syn_To_Yun; }
            set { SetPropertyValue<int>("Is_Syn_To_Yun", ref fIs_Syn_To_Yun, value); }
        }
        int fIS_Use_Net_Database;
        public int IS_Use_Net_Database
        {
            get { return fIS_Use_Net_Database; }
            set { SetPropertyValue<int>("IS_Use_Net_Database", ref fIS_Use_Net_Database, value); }
        }
        string fLocal_Database_Address;
        [Size(SizeAttribute.Unlimited)]
        public string Local_Database_Address
        {
            get { return fLocal_Database_Address; }
            set { SetPropertyValue<string>("Local_Database_Address", ref fLocal_Database_Address, value); }
        }
        DateTime fMember_Info_Update_Time;
        public DateTime Member_Info_Update_Time
        {
            get { return fMember_Info_Update_Time; }
            set { SetPropertyValue<DateTime>("Member_Info_Update_Time", ref fMember_Info_Update_Time, value); }
        }
        string fNet_Host_Database_Address;
        [Size(SizeAttribute.Unlimited)]
        public string Net_Host_Database_Address
        {
            get { return fNet_Host_Database_Address; }
            set { SetPropertyValue<string>("Net_Host_Database_Address", ref fNet_Host_Database_Address, value); }
        }
        int fPick_Type;
        public int Pick_Type
        {
            get { return fPick_Type; }
            set { SetPropertyValue<int>("Pick_Type", ref fPick_Type, value); }
        }
        int fRecord_Type;
        public int Record_Type
        {
            get { return fRecord_Type; }
            set { SetPropertyValue<int>("Record_Type", ref fRecord_Type, value); }
        }
        string fSMS_No;
        [Size(20)]
        public string SMS_No
        {
            get { return fSMS_No; }
            set { SetPropertyValue<string>("SMS_No", ref fSMS_No, value); }
        }
        string fSms_Password;
        [Size(20)]
        public string Sms_Password
        {
            get { return fSms_Password; }
            set { SetPropertyValue<string>("Sms_Password", ref fSms_Password, value); }
        }
        int fSystem_Info_ID;
        [Key(true)]
        public int System_Info_ID
        {
            get { return fSystem_Info_ID; }
            set { SetPropertyValue<int>("System_Info_ID", ref fSystem_Info_ID, value); }
        }
        DateTime fTelephonist_Info_Syn_Time;
        public DateTime Telephonist_Info_Syn_Time
        {
            get { return fTelephonist_Info_Syn_Time; }
            set { SetPropertyValue<DateTime>("Telephonist_Info_Syn_Time", ref fTelephonist_Info_Syn_Time, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        string fUpdate_Operator_No;
        [Size(20)]
        public string Update_Operator_No
        {
            get { return fUpdate_Operator_No; }
            set { SetPropertyValue<string>("Update_Operator_No", ref fUpdate_Operator_No, value); }
        }
        public t_System_Info(Session session) : base(session) { }
        public t_System_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Shopping_Guide : XPLiteObject
    {
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fGuide_ID;
        [Key(true)]
        public int Guide_ID
        {
            get { return fGuide_ID; }
            set { SetPropertyValue<int>("Guide_ID", ref fGuide_ID, value); }
        }
        string fGuide_Name;
        [Size(50)]
        public string Guide_Name
        {
            get { return fGuide_Name; }
            set { SetPropertyValue<string>("Guide_Name", ref fGuide_Name, value); }
        }
        string fGuide_No;
        [Size(50)]
        public string Guide_No
        {
            get { return fGuide_No; }
            set { SetPropertyValue<string>("Guide_No", ref fGuide_No, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        double fSales_Commissions;
        public double Sales_Commissions
        {
            get { return fSales_Commissions; }
            set { SetPropertyValue<double>("Sales_Commissions", ref fSales_Commissions, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Shopping_Guide(Session session) : base(session) { }
        public t_Shopping_Guide() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Product_Group : XPLiteObject
    {
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        string fGroup_Name;
        [Size(SizeAttribute.Unlimited)]
        public string Group_Name
        {
            get { return fGroup_Name; }
            set { SetPropertyValue<string>("Group_Name", ref fGroup_Name, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fProduct_Group_ID;
        [Key(true)]
        public int Product_Group_ID
        {
            get { return fProduct_Group_ID; }
            set { SetPropertyValue<int>("Product_Group_ID", ref fProduct_Group_ID, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Product_Group(Session session) : base(session) { }
        public t_Product_Group() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Member_Grade : XPLiteObject
    {
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        double fDiscount_Percent;
        public double Discount_Percent
        {
            get { return fDiscount_Percent; }
            set { SetPropertyValue<double>("Discount_Percent", ref fDiscount_Percent, value); }
        }
        string fGrade_Name;
        public string Grade_Name
        {
            get { return fGrade_Name; }
            set { SetPropertyValue<string>("Grade_Name", ref fGrade_Name, value); }
        }
        int fMember_Grade_ID;
        [Key(true)]
        public int Member_Grade_ID
        {
            get { return fMember_Grade_ID; }
            set { SetPropertyValue<int>("Member_Grade_ID", ref fMember_Grade_ID, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Member_Grade(Session session) : base(session) { }
        public t_Member_Grade() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Member_Info : XPLiteObject
    {
        string fAddress;
        [Size(SizeAttribute.Unlimited)]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        double fBalance;
        public double Balance
        {
            get { return fBalance; }
            set { SetPropertyValue<double>("Balance", ref fBalance, value); }
        }
        string fBirthday_Month_Day;
        [Size(4)]
        public string Birthday_Month_Day
        {
            get { return fBirthday_Month_Day; }
            set { SetPropertyValue<string>("Birthday_Month_Day", ref fBirthday_Month_Day, value); }
        }
        string fBirthday_Year;
        [Size(4)]
        public string Birthday_Year
        {
            get { return fBirthday_Year; }
            set { SetPropertyValue<string>("Birthday_Year", ref fBirthday_Year, value); }
        }
        int fBouns;
        public int Bouns
        {
            get { return fBouns; }
            set { SetPropertyValue<int>("Bouns", ref fBouns, value); }
        }
        string fCity;
        [Size(150)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        string fCompany;
        [Size(SizeAttribute.Unlimited)]
        public string Company
        {
            get { return fCompany; }
            set { SetPropertyValue<string>("Company", ref fCompany, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fCustom_Property1;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property1
        {
            get { return fCustom_Property1; }
            set { SetPropertyValue<string>("Custom_Property1", ref fCustom_Property1, value); }
        }
        string fCustom_Property2;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property2
        {
            get { return fCustom_Property2; }
            set { SetPropertyValue<string>("Custom_Property2", ref fCustom_Property2, value); }
        }
        string fCustom_Property3;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property3
        {
            get { return fCustom_Property3; }
            set { SetPropertyValue<string>("Custom_Property3", ref fCustom_Property3, value); }
        }
        string fCustom_Property4;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property4
        {
            get { return fCustom_Property4; }
            set { SetPropertyValue<string>("Custom_Property4", ref fCustom_Property4, value); }
        }
        string fCustom_Property5;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property5
        {
            get { return fCustom_Property5; }
            set { SetPropertyValue<string>("Custom_Property5", ref fCustom_Property5, value); }
        }
        string fCustom_Property6;
        [Size(SizeAttribute.Unlimited)]
        public string Custom_Property6
        {
            get { return fCustom_Property6; }
            set { SetPropertyValue<string>("Custom_Property6", ref fCustom_Property6, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        string fDistrict;
        [Size(150)]
        public string District
        {
            get { return fDistrict; }
            set { SetPropertyValue<string>("District", ref fDistrict, value); }
        }
        string fEmail;
        [Size(60)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fIdentity_No;
        public string Identity_No
        {
            get { return fIdentity_No; }
            set { SetPropertyValue<string>("Identity_No", ref fIdentity_No, value); }
        }
        int fIdentity_Type;
        public int Identity_Type
        {
            get { return fIdentity_Type; }
            set { SetPropertyValue<int>("Identity_Type", ref fIdentity_Type, value); }
        }
        string fInstant_Message;
        [Size(50)]
        public string Instant_Message
        {
            get { return fInstant_Message; }
            set { SetPropertyValue<string>("Instant_Message", ref fInstant_Message, value); }
        }
        int fIS_Share_Member_Info;
        public int IS_Share_Member_Info
        {
            get { return fIS_Share_Member_Info; }
            set { SetPropertyValue<int>("IS_Share_Member_Info", ref fIS_Share_Member_Info, value); }
        }
        int fLeaving_Deal_time;
        public int Leaving_Deal_time
        {
            get { return fLeaving_Deal_time; }
            set { SetPropertyValue<int>("Leaving_Deal_time", ref fLeaving_Deal_time, value); }
        }
        t_Member_Grade fMember_Grade_ID;
        public t_Member_Grade Member_Grade_ID
        {
            get { return fMember_Grade_ID; }
            set { SetPropertyValue<t_Member_Grade>("Member_Grade_ID", ref fMember_Grade_ID, value); }
        }
        int fMember_ID;
        [Key(true)]
        public int Member_ID
        {
            get { return fMember_ID; }
            set { SetPropertyValue<int>("Member_ID", ref fMember_ID, value); }
        }
        string fMember_Name;
        [Size(60)]
        public string Member_Name
        {
            get { return fMember_Name; }
            set { SetPropertyValue<string>("Member_Name", ref fMember_Name, value); }
        }
        string fMember_No;
        public string Member_No
        {
            get { return fMember_No; }
            set { SetPropertyValue<string>("Member_No", ref fMember_No, value); }
        }
        string fMember_Password;
        [Size(60)]
        public string Member_Password
        {
            get { return fMember_Password; }
            set { SetPropertyValue<string>("Member_Password", ref fMember_Password, value); }
        }
        string fMember_Photo;
        [Size(SizeAttribute.Unlimited)]
        public string Member_Photo
        {
            get { return fMember_Photo; }
            set { SetPropertyValue<string>("Member_Photo", ref fMember_Photo, value); }
        }
        int fMember_SID;
        public int Member_SID
        {
            get { return fMember_SID; }
            set { SetPropertyValue<int>("Member_SID", ref fMember_SID, value); }
        }
        int fMember_State;
        public int Member_State
        {
            get { return fMember_State; }
            set { SetPropertyValue<int>("Member_State", ref fMember_State, value); }
        }
        string fMobile_No;
        [Size(30)]
        public string Mobile_No
        {
            get { return fMobile_No; }
            set { SetPropertyValue<string>("Mobile_No", ref fMobile_No, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        string fProvince;
        [Size(150)]
        public string Province
        {
            get { return fProvince; }
            set { SetPropertyValue<string>("Province", ref fProvince, value); }
        }
        DateTime fReg_Date;
        public DateTime Reg_Date
        {
            get { return fReg_Date; }
            set { SetPropertyValue<DateTime>("Reg_Date", ref fReg_Date, value); }
        }
        int fRemaining_Time;
        public int Remaining_Time
        {
            get { return fRemaining_Time; }
            set { SetPropertyValue<int>("Remaining_Time", ref fRemaining_Time, value); }
        }
        int fSex;
        public int Sex
        {
            get { return fSex; }
            set { SetPropertyValue<int>("Sex", ref fSex, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fTel;
        [Size(200)]
        public string Tel
        {
            get { return fTel; }
            set { SetPropertyValue<string>("Tel", ref fTel, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        DateTime fValidity_Date;
        public DateTime Validity_Date
        {
            get { return fValidity_Date; }
            set { SetPropertyValue<DateTime>("Validity_Date", ref fValidity_Date, value); }
        }
        public t_Member_Info(Session session) : base(session) { }
        public t_Member_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Member_Deal_History : XPLiteObject
    {
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        DateTime fDeal_DateTime;
        public DateTime Deal_DateTime
        {
            get { return fDeal_DateTime; }
            set { SetPropertyValue<DateTime>("Deal_DateTime", ref fDeal_DateTime, value); }
        }
        int fDeal_History_ID;
        [Key(true)]
        public int Deal_History_ID
        {
            get { return fDeal_History_ID; }
            set { SetPropertyValue<int>("Deal_History_ID", ref fDeal_History_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fGet_Bonus;
        public int Get_Bonus
        {
            get { return fGet_Bonus; }
            set { SetPropertyValue<int>("Get_Bonus", ref fGet_Bonus, value); }
        }
        int fGuide_ID;
        public int Guide_ID
        {
            get { return fGuide_ID; }
            set { SetPropertyValue<int>("Guide_ID", ref fGuide_ID, value); }
        }
        string fGuide_Name;
        [Size(50)]
        public string Guide_Name
        {
            get { return fGuide_Name; }
            set { SetPropertyValue<string>("Guide_Name", ref fGuide_Name, value); }
        }
        string fGuide_No;
        [Size(50)]
        public string Guide_No
        {
            get { return fGuide_No; }
            set { SetPropertyValue<string>("Guide_No", ref fGuide_No, value); }
        }
        int fGuide2_ID;
        public int Guide2_ID
        {
            get { return fGuide2_ID; }
            set { SetPropertyValue<int>("Guide2_ID", ref fGuide2_ID, value); }
        }
        string fGuide2_Name;
        [Size(50)]
        public string Guide2_Name
        {
            get { return fGuide2_Name; }
            set { SetPropertyValue<string>("Guide2_Name", ref fGuide2_Name, value); }
        }
        string fGuide2_No;
        [Size(50)]
        public string Guide2_No
        {
            get { return fGuide2_No; }
            set { SetPropertyValue<string>("Guide2_No", ref fGuide2_No, value); }
        }
        int fGuide3_ID;
        public int Guide3_ID
        {
            get { return fGuide3_ID; }
            set { SetPropertyValue<int>("Guide3_ID", ref fGuide3_ID, value); }
        }
        string fGuide3_Name;
        [Size(50)]
        public string Guide3_Name
        {
            get { return fGuide3_Name; }
            set { SetPropertyValue<string>("Guide3_Name", ref fGuide3_Name, value); }
        }
        string fGuide3_No;
        [Size(50)]
        public string Guide3_No
        {
            get { return fGuide3_No; }
            set { SetPropertyValue<string>("Guide3_No", ref fGuide3_No, value); }
        }
        int fGuide4_ID;
        public int Guide4_ID
        {
            get { return fGuide4_ID; }
            set { SetPropertyValue<int>("Guide4_ID", ref fGuide4_ID, value); }
        }
        string fGuide4_Name;
        [Size(50)]
        public string Guide4_Name
        {
            get { return fGuide4_Name; }
            set { SetPropertyValue<string>("Guide4_Name", ref fGuide4_Name, value); }
        }
        string fGuide4_No;
        [Size(50)]
        public string Guide4_No
        {
            get { return fGuide4_No; }
            set { SetPropertyValue<string>("Guide4_No", ref fGuide4_No, value); }
        }
        int fIsHungRecord;
        public int IsHungRecord
        {
            get { return fIsHungRecord; }
            set { SetPropertyValue<int>("State", ref fIsHungRecord, value); }
        }
        double fKouChu_Card_Balance;
        public double KouChu_Card_Balance
        {
            get { return fKouChu_Card_Balance; }
            set { SetPropertyValue<double>("KouChu_Card_Balance", ref fKouChu_Card_Balance, value); }
        }
        int fKouChu_Deal_Time;
        public int KouChu_Deal_Time
        {
            get { return fKouChu_Deal_Time; }
            set { SetPropertyValue<int>("KouChu_Deal_Time", ref fKouChu_Deal_Time, value); }
        }
        double fLeave_Balance;
        public double Leave_Balance
        {
            get { return fLeave_Balance; }
            set { SetPropertyValue<double>("Leave_Balance", ref fLeave_Balance, value); }
        }
        int fLeave_Deal_Time;
        public int Leave_Deal_Time
        {
            get { return fLeave_Deal_Time; }
            set { SetPropertyValue<int>("Leave_Deal_Time", ref fLeave_Deal_Time, value); }
        }
        double fLooseCharge;
        public double LooseCharge
        {
            get { return fLooseCharge; }
            set { SetPropertyValue<double>("LooseCharge", ref fLooseCharge, value); }
        }
        t_Member_Info fMember_ID;
        public t_Member_Info Member_ID
        {
            get { return fMember_ID; }
            set { SetPropertyValue<t_Member_Info>("Member_ID", ref fMember_ID, value); }
        }
        string fMember_No;
        public string Member_No
        {
            get { return fMember_No; }
            set { SetPropertyValue<string>("Member_No", ref fMember_No, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fPay_Type;
        public int Pay_Type
        {
            get { return fPay_Type; }
            set { SetPropertyValue<int>("Pay_Type", ref fPay_Type, value); }
        }
        double fShiShou_Cash;
        public double ShiShou_Cash
        {
            get { return fShiShou_Cash; }
            set { SetPropertyValue<double>("ShiShou_Cash", ref fShiShou_Cash, value); }
        }
        double fShouDao_cash;
        public double ShouDao_cash
        {
            get { return fShouDao_cash; }
            set { SetPropertyValue<double>("ShouDao_cash", ref fShouDao_cash, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        double fYingShou_Money;
        public double YingShou_Money
        {
            get { return fYingShou_Money; }
            set { SetPropertyValue<double>("YingShou_Money", ref fYingShou_Money, value); }
        }
        double fYouHui_Money;
        public double YouHui_Money
        {
            get { return fYouHui_Money; }
            set { SetPropertyValue<double>("YouHui_Money", ref fYouHui_Money, value); }
        }
        double fZheHou_Money;
        public double ZheHou_Money
        {
            get { return fZheHou_Money; }
            set { SetPropertyValue<double>("ZheHou_Money", ref fZheHou_Money, value); }
        }
        public t_Member_Deal_History(Session session) : base(session) { }
        public t_Member_Deal_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Business_Log : XPLiteObject
    {
        string fAction_ID;
        public string Action_ID
        {
            get { return fAction_ID; }
            set { SetPropertyValue<string>("Action_ID", ref fAction_ID, value); }
        }
        string fAction_Name;
        public string Action_Name
        {
            get { return fAction_Name; }
            set { SetPropertyValue<string>("Action_Name", ref fAction_Name, value); }
        }
        DateTime fAction_Time;
        public DateTime Action_Time
        {
            get { return fAction_Time; }
            set { SetPropertyValue<DateTime>("Action_Time", ref fAction_Time, value); }
        }
        int fAction_Type;
        public int Action_Type
        {
            get { return fAction_Type; }
            set { SetPropertyValue<int>("Action_Type", ref fAction_Type, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fLog_ID;
        [Key(true)]
        public int Log_ID
        {
            get { return fLog_ID; }
            set { SetPropertyValue<int>("Log_ID", ref fLog_ID, value); }
        }
        string fMsg;
        [Size(SizeAttribute.Unlimited)]
        public string Msg
        {
            get { return fMsg; }
            set { SetPropertyValue<string>("Msg", ref fMsg, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fRecode_ID;
        public int Recode_ID
        {
            get { return fRecode_ID; }
            set { SetPropertyValue<int>("Recode_ID", ref fRecode_ID, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        public t_Business_Log(Session session) : base(session) { }
        public t_Business_Log() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Operator_Login_History : XPLiteObject
    {
        string fBrowser_Info;
        public string Browser_Info
        {
            get { return fBrowser_Info; }
            set { SetPropertyValue<string>("Browser_Info", ref fBrowser_Info, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fCompany_No;
        public string Company_No
        {
            get { return fCompany_No; }
            set { SetPropertyValue<string>("Company_No", ref fCompany_No, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        string fIP_Address;
        [Size(64)]
        public string IP_Address
        {
            get { return fIP_Address; }
            set { SetPropertyValue<string>("IP_Address", ref fIP_Address, value); }
        }
        int fLogin_From;
        public int Login_From
        {
            get { return fLogin_From; }
            set { SetPropertyValue<int>("Login_From", ref fLogin_From, value); }
        }
        int fLogin_ID;
        [Key(true)]
        public int Login_ID
        {
            get { return fLogin_ID; }
            set { SetPropertyValue<int>("Login_ID", ref fLogin_ID, value); }
        }
        DateTime fLogin_Time;
        public DateTime Login_Time
        {
            get { return fLogin_Time; }
            set { SetPropertyValue<DateTime>("Login_Time", ref fLogin_Time, value); }
        }
        int fLogin_Type;
        public int Login_Type
        {
            get { return fLogin_Type; }
            set { SetPropertyValue<int>("Login_Type", ref fLogin_Type, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fOperator_Type;
        public int Operator_Type
        {
            get { return fOperator_Type; }
            set { SetPropertyValue<int>("Operator_Type", ref fOperator_Type, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        public t_Operator_Login_History(Session session) : base(session) { }
        public t_Operator_Login_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Bonus_Exchange_History : XPLiteObject
    {
        int fBonus_Num;
        public int Bonus_Num
        {
            get { return fBonus_Num; }
            set { SetPropertyValue<int>("Bonus_Num", ref fBonus_Num, value); }
        }
        int fBonus_Type;
        public int Bonus_Type
        {
            get { return fBonus_Type; }
            set { SetPropertyValue<int>("Bonus_Type", ref fBonus_Type, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        DateTime fExchange_DateTime;
        public DateTime Exchange_DateTime
        {
            get { return fExchange_DateTime; }
            set { SetPropertyValue<DateTime>("Exchange_DateTime", ref fExchange_DateTime, value); }
        }
        int fExchange_History_ID;
        [Key(true)]
        public int Exchange_History_ID
        {
            get { return fExchange_History_ID; }
            set { SetPropertyValue<int>("Exchange_History_ID", ref fExchange_History_ID, value); }
        }
        t_Member_Info fMember_ID;
        public t_Member_Info Member_ID
        {
            get { return fMember_ID; }
            set { SetPropertyValue<t_Member_Info>("Member_ID", ref fMember_ID, value); }
        }
        string fMember_No;
        public string Member_No
        {
            get { return fMember_No; }
            set { SetPropertyValue<string>("Member_No", ref fMember_No, value); }
        }
        double fMoney_Num;
        public double Money_Num
        {
            get { return fMoney_Num; }
            set { SetPropertyValue<double>("Money_Num", ref fMoney_Num, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        int fSurplus_Bonus;
        public int Surplus_Bonus
        {
            get { return fSurplus_Bonus; }
            set { SetPropertyValue<int>("Surplus_Bonus", ref fSurplus_Bonus, value); }
        }
        double fSurplus_Money;
        public double Surplus_Money
        {
            get { return fSurplus_Money; }
            set { SetPropertyValue<double>("Surplus_Money", ref fSurplus_Money, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Bonus_Exchange_History(Session session) : base(session) { }
        public t_Bonus_Exchange_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Product_Sale_Info : XPLiteObject
    {
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fExchange_Bouns;
        public int Exchange_Bouns
        {
            get { return fExchange_Bouns; }
            set { SetPropertyValue<int>("Exchange_Bouns", ref fExchange_Bouns, value); }
        }
        int fIs_Bonus_Exchange;
        public int Is_Bonus_Exchange
        {
            get { return fIs_Bonus_Exchange; }
            set { SetPropertyValue<int>("Is_Bonus_Exchange", ref fIs_Bonus_Exchange, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        t_Product_Info fProduct_Info_ID;
        public t_Product_Info Product_Info_ID
        {
            get { return fProduct_Info_ID; }
            set { SetPropertyValue<t_Product_Info>("Product_Info_ID", ref fProduct_Info_ID, value); }
        }
        int fProduct_Sale_ID;
        [Key(true)]
        public int Product_Sale_ID
        {
            get { return fProduct_Sale_ID; }
            set { SetPropertyValue<int>("Product_Sale_ID", ref fProduct_Sale_ID, value); }
        }
        int fProduct_State;
        public int Product_State
        {
            get { return fProduct_State; }
            set { SetPropertyValue<int>("Product_State", ref fProduct_State, value); }
        }
        double fPurchase_Price;
        public double Purchase_Price
        {
            get { return fPurchase_Price; }
            set { SetPropertyValue<double>("Purchase_Price", ref fPurchase_Price, value); }
        }
        int fReserve_Count;
        public int Reserve_Count
        {
            get { return fReserve_Count; }
            set { SetPropertyValue<int>("Reserve_Count", ref fReserve_Count, value); }
        }
        double fSale_Price;
        public double Sale_Price
        {
            get { return fSale_Price; }
            set { SetPropertyValue<double>("Sale_Price", ref fSale_Price, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Product_Sale_Info(Session session) : base(session) { }
        public t_Product_Sale_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Store_Info : XPLiteObject
    {
        int fBonus_Exchange_Print_Report_Num;
        public int Bonus_Exchange_Print_Report_Num
        {
            get { return fBonus_Exchange_Print_Report_Num; }
            set { SetPropertyValue<int>("Bonus_Exchange_Print_Report_Num", ref fBonus_Exchange_Print_Report_Num, value); }
        }
        int fBonus_Ratio;
        public int Bonus_Ratio
        {
            get { return fBonus_Ratio; }
            set { SetPropertyValue<int>("Bonus_Ratio", ref fBonus_Ratio, value); }
        }
        double fBonus_to_Money_Ratio;
        public double Bonus_to_Money_Ratio
        {
            get { return fBonus_to_Money_Ratio; }
            set { SetPropertyValue<double>("Bonus_to_Money_Ratio", ref fBonus_to_Money_Ratio, value); }
        }
        int fCan_Modifi_Bonus;
        public int Can_Modifi_Bonus
        {
            get { return fCan_Modifi_Bonus; }
            set { SetPropertyValue<int>("Can_Modifi_Bonus", ref fCan_Modifi_Bonus, value); }
        }
        int fCan_Modifi_Discount;
        public int Can_Modifi_Discount
        {
            get { return fCan_Modifi_Discount; }
            set { SetPropertyValue<int>("Can_Modifi_Discount", ref fCan_Modifi_Discount, value); }
        }
        int fCan_Modifi_Money;
        public int Can_Modifi_Money
        {
            get { return fCan_Modifi_Money; }
            set { SetPropertyValue<int>("Can_Modifi_Money", ref fCan_Modifi_Money, value); }
        }
        int fCharge_Print_Report_Num;
        public int Charge_Print_Report_Num
        {
            get { return fCharge_Print_Report_Num; }
            set { SetPropertyValue<int>("Charge_Print_Report_Num", ref fCharge_Print_Report_Num, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        int fCreate_Member_Print_Report_Num;
        public int Create_Member_Print_Report_Num
        {
            get { return fCreate_Member_Print_Report_Num; }
            set { SetPropertyValue<int>("Create_Member_Print_Report_Num", ref fCreate_Member_Print_Report_Num, value); }
        }
        int fDeal_Print_Report_Num;
        public int Deal_Print_Report_Num
        {
            get { return fDeal_Print_Report_Num; }
            set { SetPropertyValue<int>("Deal_Print_Report_Num", ref fDeal_Print_Report_Num, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        int fIs_Auto_Send_Birthday_Sms;
        public int Is_Auto_Send_Birthday_Sms
        {
            get { return fIs_Auto_Send_Birthday_Sms; }
            set { SetPropertyValue<int>("Is_Auto_Send_Birthday_Sms", ref fIs_Auto_Send_Birthday_Sms, value); }
        }
        int fIs_Bonus_Exchange_Print_Report;
        public int Is_Bonus_Exchange_Print_Report
        {
            get { return fIs_Bonus_Exchange_Print_Report; }
            set { SetPropertyValue<int>("Is_Bonus_Exchange_Print_Report", ref fIs_Bonus_Exchange_Print_Report, value); }
        }
        int fIs_Charge_Print_Report;
        public int Is_Charge_Print_Report
        {
            get { return fIs_Charge_Print_Report; }
            set { SetPropertyValue<int>("Is_Charge_Print_Report", ref fIs_Charge_Print_Report, value); }
        }
        int fIs_Create_Member_Print_Report;
        public int Is_Create_Member_Print_Report
        {
            get { return fIs_Create_Member_Print_Report; }
            set { SetPropertyValue<int>("Is_Create_Member_Print_Report", ref fIs_Create_Member_Print_Report, value); }
        }
        int fIs_Deal_Print_Report;
        public int Is_Deal_Print_Report
        {
            get { return fIs_Deal_Print_Report; }
            set { SetPropertyValue<int>("Is_Deal_Print_Report", ref fIs_Deal_Print_Report, value); }
        }
        int fIs_Send_BonusExchange_Sms;
        public int Is_Send_BonusExchange_Sms
        {
            get { return fIs_Send_BonusExchange_Sms; }
            set { SetPropertyValue<int>("Is_Send_BonusExchange_Sms", ref fIs_Send_BonusExchange_Sms, value); }
        }
        int fIs_Send_Charge_Sms;
        public int Is_Send_Charge_Sms
        {
            get { return fIs_Send_Charge_Sms; }
            set { SetPropertyValue<int>("Is_Send_Charge_Sms", ref fIs_Send_Charge_Sms, value); }
        }
        int fIs_Send_Deal_Sms;
        public int Is_Send_Deal_Sms
        {
            get { return fIs_Send_Deal_Sms; }
            set { SetPropertyValue<int>("Is_Send_Deal_Sms", ref fIs_Send_Deal_Sms, value); }
        }
        int fIs_Send_NewMember_Sms;
        public int Is_Send_NewMember_Sms
        {
            get { return fIs_Send_NewMember_Sms; }
            set { SetPropertyValue<int>("Is_Send_NewMember_Sms", ref fIs_Send_NewMember_Sms, value); }
        }
        int fIS_Share_Member_Info;
        public int IS_Share_Member_Info
        {
            get { return fIS_Share_Member_Info; }
            set { SetPropertyValue<int>("IS_Share_Member_Info", ref fIS_Share_Member_Info, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fPay_Type;
        public int Pay_Type
        {
            get { return fPay_Type; }
            set { SetPropertyValue<int>("Pay_Type", ref fPay_Type, value); }
        }
        string fReport_Tel;
        [Size(60)]
        public string Report_Tel
        {
            get { return fReport_Tel; }
            set { SetPropertyValue<string>("Report_Tel", ref fReport_Tel, value); }
        }
        string fReport_Title;
        [Size(150)]
        public string Report_Title
        {
            get { return fReport_Title; }
            set { SetPropertyValue<string>("Report_Title", ref fReport_Title, value); }
        }
        string fSms_Send_Name;
        [Size(30)]
        public string Sms_Send_Name
        {
            get { return fSms_Send_Name; }
            set { SetPropertyValue<string>("Sms_Send_Name", ref fSms_Send_Name, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        [Key(true)]
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Store_Info(Session session) : base(session) { }
        public t_Store_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Product_Info : XPLiteObject
    {
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        t_Product_Group fProduct_Group_ID;
        public t_Product_Group Product_Group_ID
        {
            get { return fProduct_Group_ID; }
            set { SetPropertyValue<t_Product_Group>("Product_Group_ID", ref fProduct_Group_ID, value); }
        }
        int fProduct_Info_ID;
        [Key(true)]
        public int Product_Info_ID
        {
            get { return fProduct_Info_ID; }
            set { SetPropertyValue<int>("Product_Info_ID", ref fProduct_Info_ID, value); }
        }
        string fProduct_Info_No;
        [Size(50)]
        public string Product_Info_No
        {
            get { return fProduct_Info_No; }
            set { SetPropertyValue<string>("Product_Info_No", ref fProduct_Info_No, value); }
        }
        string fProduct_Name;
        [Size(SizeAttribute.Unlimited)]
        public string Product_Name
        {
            get { return fProduct_Name; }
            set { SetPropertyValue<string>("Product_Name", ref fProduct_Name, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Product_Info(Session session) : base(session) { }
        public t_Product_Info() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Call_History : XPLiteObject
    {
        DateTime fCall_End_Time;
        public DateTime Call_End_Time
        {
            get { return fCall_End_Time; }
            set { SetPropertyValue<DateTime>("Call_End_Time", ref fCall_End_Time, value); }
        }
        int fCall_History_ID;
        [Key(true)]
        public int Call_History_ID
        {
            get { return fCall_History_ID; }
            set { SetPropertyValue<int>("Call_History_ID", ref fCall_History_ID, value); }
        }
        int fCall_Length;
        public int Call_Length
        {
            get { return fCall_Length; }
            set { SetPropertyValue<int>("Call_Length", ref fCall_Length, value); }
        }
        DateTime fCall_Start_Time;
        public DateTime Call_Start_Time
        {
            get { return fCall_Start_Time; }
            set { SetPropertyValue<DateTime>("Call_Start_Time", ref fCall_Start_Time, value); }
        }
        int fCall_Type;
        public int Call_Type
        {
            get { return fCall_Type; }
            set { SetPropertyValue<int>("Call_Type", ref fCall_Type, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        t_Member_Info fMember_ID;
        public t_Member_Info Member_ID
        {
            get { return fMember_ID; }
            set { SetPropertyValue<t_Member_Info>("Member_ID", ref fMember_ID, value); }
        }
        t_Operator_Info fOperator_ID;
        public t_Operator_Info Operator_ID
        {
            get { return fOperator_ID; }
            set { SetPropertyValue<t_Operator_Info>("Operator_ID", ref fOperator_ID, value); }
        }
        string fPhone_No;
        [Size(20)]
        public string Phone_No
        {
            get { return fPhone_No; }
            set { SetPropertyValue<string>("Phone_No", ref fPhone_No, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Call_History(Session session) : base(session) { }
        public t_Call_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Consume_Content : XPLiteObject
    {
        string fContent;
        [Size(50)]
        public string Content
        {
            get { return fContent; }
            set { SetPropertyValue<string>("Content", ref fContent, value); }
        }
        int fContent_ID;
        [Key(true)]
        public int Content_ID
        {
            get { return fContent_ID; }
            set { SetPropertyValue<int>("Content_ID", ref fContent_ID, value); }
        }
        int fContent_Type;
        public int Content_Type
        {
            get { return fContent_Type; }
            set { SetPropertyValue<int>("Content_Type", ref fContent_Type, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Consume_Content(Session session) : base(session) { }
        public t_Consume_Content() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class t_Sms_Send_History : XPLiteObject
    {
        int fCompany_ID;
        public int Company_ID
        {
            get { return fCompany_ID; }
            set { SetPropertyValue<int>("Company_ID", ref fCompany_ID, value); }
        }
        DateTime fCreate_Datetime;
        public DateTime Create_Datetime
        {
            get { return fCreate_Datetime; }
            set { SetPropertyValue<DateTime>("Create_Datetime", ref fCreate_Datetime, value); }
        }
        int fCurrent_Sms_Count;
        public int Current_Sms_Count
        {
            get { return fCurrent_Sms_Count; }
            set { SetPropertyValue<int>("Current_Sms_Count", ref fCurrent_Sms_Count, value); }
        }
        string fDelete_No;
        [Size(35)]
        public string Delete_No
        {
            get { return fDelete_No; }
            set { SetPropertyValue<string>("Delete_No", ref fDelete_No, value); }
        }
        string fError_Code;
        [Size(10)]
        public string Error_Code
        {
            get { return fError_Code; }
            set { SetPropertyValue<string>("Error_Code", ref fError_Code, value); }
        }
        string fError_Info;
        [Size(SizeAttribute.Unlimited)]
        public string Error_Info
        {
            get { return fError_Info; }
            set { SetPropertyValue<string>("Error_Info", ref fError_Info, value); }
        }
        int fHistory_ID;
        [Key(true)]
        public int History_ID
        {
            get { return fHistory_ID; }
            set { SetPropertyValue<int>("History_ID", ref fHistory_ID, value); }
        }
        int fKouChu_Send_Num;
        public int KouChu_Send_Num
        {
            get { return fKouChu_Send_Num; }
            set { SetPropertyValue<int>("KouChu_Send_Num", ref fKouChu_Send_Num, value); }
        }
        int fMobile_Num;
        public int Mobile_Num
        {
            get { return fMobile_Num; }
            set { SetPropertyValue<int>("Mobile_Num", ref fMobile_Num, value); }
        }
        string fOperator_No;
        [Size(50)]
        public string Operator_No
        {
            get { return fOperator_No; }
            set { SetPropertyValue<string>("Operator_No", ref fOperator_No, value); }
        }
        string fReceive_Mobile_No;
        [Size(SizeAttribute.Unlimited)]
        public string Receive_Mobile_No
        {
            get { return fReceive_Mobile_No; }
            set { SetPropertyValue<string>("Receive_Mobile_No", ref fReceive_Mobile_No, value); }
        }
        DateTime fSend_DateTime;
        public DateTime Send_DateTime
        {
            get { return fSend_DateTime; }
            set { SetPropertyValue<DateTime>("Send_DateTime", ref fSend_DateTime, value); }
        }
        int fSend_State;
        public int Send_State
        {
            get { return fSend_State; }
            set { SetPropertyValue<int>("Send_State", ref fSend_State, value); }
        }
        string fSms_Content;
        [Size(SizeAttribute.Unlimited)]
        public string Sms_Content
        {
            get { return fSms_Content; }
            set { SetPropertyValue<string>("Sms_Content", ref fSms_Content, value); }
        }
        int fSms_Content_Length;
        public int Sms_Content_Length
        {
            get { return fSms_Content_Length; }
            set { SetPropertyValue<int>("Sms_Content_Length", ref fSms_Content_Length, value); }
        }
        int fSms_Prior_Level;
        public int Sms_Prior_Level
        {
            get { return fSms_Prior_Level; }
            set { SetPropertyValue<int>("Sms_Prior_Level", ref fSms_Prior_Level, value); }
        }
        int fSms_Type;
        public int Sms_Type
        {
            get { return fSms_Type; }
            set { SetPropertyValue<int>("Sms_Type", ref fSms_Type, value); }
        }
        int fState;
        public int State
        {
            get { return fState; }
            set { SetPropertyValue<int>("State", ref fState, value); }
        }
        int fStore_ID;
        public int Store_ID
        {
            get { return fStore_ID; }
            set { SetPropertyValue<int>("Store_ID", ref fStore_ID, value); }
        }
        string fStore_Name;
        public string Store_Name
        {
            get { return fStore_Name; }
            set { SetPropertyValue<string>("Store_Name", ref fStore_Name, value); }
        }
        DateTime fUpdate_DateTime;
        public DateTime Update_DateTime
        {
            get { return fUpdate_DateTime; }
            set { SetPropertyValue<DateTime>("Update_DateTime", ref fUpdate_DateTime, value); }
        }
        public t_Sms_Send_History(Session session) : base(session) { }
        public t_Sms_Send_History() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
