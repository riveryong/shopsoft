using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopsoft.common.Const
{
    public static class MessageConst
    {
        #region 错误消息
        public const string errMsg_noInput = "请输入会员编号！";
        public const string errMsg_memberExited = "会员编号已存在！";
        public const string errMsg_noMemberGrade = "请选择会员等级！";
        public const string errMsg_BonusErr = "会员初始积分应大于等于0";
        public const string errMsg_noValidityDate = "请选择会员有效期";
        public const string errMsg_ValidityDateErr = "会员有效期应该在今天之后";
        public const string errMsg_noSelect = "请选择一个会员！";
        public const string errMsg_DataError = "该用户数据异常，请重新选择!";
        public const string errMsg_DirectErr = "文件夹异常：找不到【ConfigFiles】文件夹!";
        public const string errMsg_FileErr = "数据文件异常：找不到数据文件!";
        public const string errMsg_MobileErr = "手机号格式不正确，请重新输入！";
        public const string errMsg_noInputCharge = "请输入至少一项充值内容！";
        public const string errMsg_chargeFaild = "会员充值失败";

        public const string errMsg_ConsumeItemExited = "消费备注已存在！";
        public const string errMsg_ConsumeItemUnselect = "请选择一个会员！";
        public const string errMsg_ConsumeItemIsDel = "是否删除消费项目：";
        public const string errMsg_ConsumeFaild = "消费记录保存失败，请重新输入。";
        public const string errMsg_MemberConsum_InputConsum = "请输入消费金额";
        public const string errMsg_MemberTimesConsum_InputTimes = "请输入消费次数";

        public const string errMsg_BonusExchange_NoInput = "请输入扣减积分。";
        public const string errMsg_BonusExchange_NoEnough = "扣减积分已超过会员积分，请重新输入。";
        public const string errMsg_BonusExchangeFaild = "积分兑换失败，请重新操作。";

        public const string errMsg_BonusMeger_NoInput = "请输入{0}的会员卡号！";
        public const string errMsg_BonusMeger_ErrorData = "{0}的数据异常，请重新输入卡号！";
        public const string errMsg_BonusMegerFaild = "积分合并失败，请重新操作。";
        #endregion

        #region 提示消息
        public const string info_MemberCreateSuccess = "添加会员成功。";
        public const string info_MemberUpdateSuccess = "修改会员信息成功。";
        public const string info_MemberChargeSuccess = "会员充值成功。";
        public const string info_MemberConsumeSucces = "会员消费成功。";
        public const string info_BonusExchangeSucces = "积分兑换成功。";
        public const string info_bonusMegerSuccess = "积分合并成功";
               
        #endregion
    }
}
