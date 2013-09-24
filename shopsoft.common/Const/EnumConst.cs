using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopsoft.common.Const
{

    #region 数据状态枚举类型
    /// <summary>
    /// 数据状态枚举类型
    /// </summary>
    public static class RecordState
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const int Normal = 0;

        /// <summary>
        /// 已删除
        /// </summary>
        public const int Deleted = 1;
    }
    #endregion

    #region 会员状态枚举类型
    /// <summary>
    /// 会员状态枚举类型
    /// </summary>
    public static class MemberState
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const int Normal = 0;

        /// <summary>
        /// 过期
        /// </summary>
        public const int PastDue = 1;

        /// <summary>
        /// 挂失
        /// </summary>
        public const int GuaShi = 2;

        /// <summary>
        /// 被锁定
        /// </summary>
        public const int Locked = 3;
    }
    #endregion

    #region 角色枚举类型
    /// <summary>
    /// 角色枚举类型
    /// </summary>
    public static class Role
    {
        /// <summary>
        /// 企业管理员
        /// </summary>
        public const int Manager = 0;

        /// <summary>
        /// 店铺操作员
        /// </summary>
        public const int Worker = 1;

    }
    #endregion

    #region 是否枚举类型
    /// <summary>
    /// 是否枚举类型
    /// </summary>
    public static class YesOrNo
    {
        /// <summary>
        /// 是
        /// </summary>
        public const int Yes = 1;

        /// <summary>
        /// 否
        /// </summary>
        public const int No = 0;

    }
    #endregion

    #region 操作员状态枚举类型
    /// <summary>
    /// 操作员状态枚举类型
    /// </summary>
    public static class OperatorState
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const int Normal = 0;

        /// <summary>
        /// 锁定
        /// </summary>
        public const int Locked = 1;
    }
    #endregion

    #region 商品是否可积分兑换
    /// <summary>
    /// 商品是否可积分兑换
    /// </summary>
    public static class ProductIsBonusExchange
    {
        /// <summary>
        /// 不能积分兑换
        /// </summary>
        public const int NotExchange = 0;

        /// <summary>
        /// 可以积分兑换
        /// </summary>
        public const int IsExchange = 1;

    }
    #endregion

    #region 支付方式
    /// <summary>
    /// 支付方式
    /// </summary>
    public static class PayType
    {
        /// <summary>
        /// 商品商品消费
        /// </summary>
        public const int ProductPay = 0;

        /// <summary>
        /// 快速消费
        /// </summary>
        public const int WorkPay = 1;

        /// <summary>
        /// 计次消费
        /// </summary>
        public const int TimePay = 2;

    }
    #endregion

    #region 积分兑换方式
    /// <summary>
    /// 积分兑换方式
    /// </summary>
    public static class BonusExchangeType
    {
        /// <summary>
        /// 积分兑换金额
        /// </summary>
        public const int MoneyExchange = 0;

        /// <summary>
        /// 积分合并
        /// </summary>
        public const int BonusMerger = 1;

        /// <summary>
        /// 积分兑换商品
        /// </summary>
        public const int ProductExchange = 2;

    }
    #endregion

    #region 性别
    ///
    public static class Sex
    {
        /// <summary>
        /// 男
        /// </summary>
        public const int Man = 1;

        /// <summary>
        /// 女
        /// </summary>
        public const int Woman = 2;
    }
    #endregion

    #region 备注类别
    public static class ContentType
    {
        /// <summary>
        /// 快速消费备注
        /// </summary>
        public const int Consume = 1;
    }

    #endregion



    #region 公司状态枚举类型
    /// <summary>
    /// 公司状态枚举类型
    /// </summary>
    public static class CompanyState
    {
        /// <summary>
        /// 正常
        /// </summary>
        public const int Normal = 0;

        /// <summary>
        /// 锁定
        /// </summary>
        public const int Forbidden = 1;

        /// <summary>
        /// 注销
        /// </summary>
        public const int Cancellation = 2;
    }
    #endregion

    #region 商品销售状态
    /// <summary>
    /// 商品销售状态
    /// </summary>
    public static class ProductSaleState
    {
        /// <summary>
        /// 未上架
        /// </summary>
        public const int NotPrice = 0;

        /// <summary>
        /// 已上架
        /// </summary>
        public const int HavePrice = 1;

    }
    #endregion    

    #region 是否是默认折扣
    /// <summary>
    /// 是否是默认折扣
    /// </summary>
    public static class MemberGradeIsDefaultDiscount
    {
        /// <summary>
        /// 不是默认折扣
        /// </summary>
        public const int NotDefaultDiscount = 0;

        /// <summary>
        /// 默认折扣
        /// </summary>
        public const int IsDefaultDiscount = 1;

    }
    #endregion

    #region 会员是否共享
    /// <summary>
    /// 会员是否共享枚举类型
    /// </summary>
    public static class IsShareMember
    {
        /// <summary>
        /// 不共享
        /// </summary>
        public const int No = 0;

        /// <summary>
        /// 共享
        /// </summary>
        public const int Yes = 1;
    }
    #endregion

    #region 业务编号
    /// <summary>
    /// 业务编号
    /// </summary>
    public static class BusinessNo
    {
        /// <summary>
        /// 店铺管理
        /// </summary>
        public const int StoreManage = 0;
        /// <summary>
        /// 积分兑换
        /// </summary>
        public const int BonusExchange = 1;

    }
    #endregion

    #region 操作类型
    /// <summary>
    /// 操作类型
    /// </summary>
    public static class ActionType
    {
        /// <summary>
        /// 新建
        /// </summary>
        public const int Add = 0;

        /// <summary>
        /// 更新
        /// </summary>
        public const int Update = 1;

        /// <summary>
        /// 删除
        /// </summary>
        public const int Delete = 2;

    }
    #endregion

    #region 短信发送状态
    /// <summary>
    /// 短信发送状态
    /// </summary>
    public static class SmsState
    {
        /// <summary>
        /// 等待发送
        /// </summary>
        public const int Waiting = 1;

        /// <summary>
        /// 正在发送
        /// </summary>
        public const int Sending = 2;

        /// <summary>
        /// 发送成功
        /// </summary>
        public const int SendSucceed = 3;

        /// <summary>
        /// 发送失败
        /// </summary>
        public const int SendFailed = 4;
    }
    #endregion

    #region 短信发送优先级
    /// <summary>
    /// 短信发送优先级
    /// </summary>
    public static class SmsPriorLevel
    {
        /// <summary>
        /// 普通(群发短信、生日提醒等)
        /// </summary>
        public const int Normal = 1;

        /// <summary>
        /// 中等(建卡、消费、充值、积分兑换等)
        /// </summary>
        public const int Middle = 2;

        /// <summary>
        /// 最优先
        /// </summary>
        public const int High = 3;
    }
    #endregion

    #region 短信类型
    /// <summary>
    /// 短信类型
    /// </summary>
    public static class SmsType
    {
        /// <summary>
        /// 充值短信
        /// </summary>
        public const int ChargeSms = 1;

        /// <summary>
        /// 新建会员短信
        /// </summary>
        public const int CreateMemberSms = 2;

        /// <summary>
        /// 消费短信
        /// </summary>
        public const int DealSms = 3;

        /// <summary>
        /// 群发短信
        /// </summary>
        public const int SendGroupSms = 4;

        /// <summary>
        /// 生日短信
        /// </summary>
        public const int BirthdaySms = 5;

        /// <summary>
        /// 积分兑换
        /// </summary>
        public const int ExchangeBonus = 6;

        /// <summary>
        /// 系统短信
        /// </summary>
        public const int SystemSms = 7;
    }
    #endregion

    #region 证件类型
    /// <summary>
    /// 证件类型
    /// </summary>
    public static class IdentityType
    {
        /// <summary>
        /// 身份证
        /// </summary>
        public const int IdCard = 1;

        /// <summary>
        /// 户口本
        /// </summary>
        public const int Householder = 2;

    }
    #endregion

    #region 登陆类型
    /// <summary>
    /// 登陆类型
    /// </summary>
    public static class LoginType
    {
        /// <summary>
        /// 登陆
        /// </summary>
        public const int Login = 0;

        /// <summary>
        /// 退出
        /// </summary>
        public const int Logout = 1;

    }
    #endregion

    #region 运维管理员角色
    /// <summary>
    /// 运维管理员角色
    /// </summary>
    public static class SysManagerType
    {
        /// <summary>
        /// 一级管理员
        /// </summary>
        public const int ManagerType1 = 1;

        /// <summary>
        /// 二级管理员
        /// </summary>
        public const int ManagerType2 = 2;

        /// <summary>
        /// 三级管理员
        /// </summary>
        public const int ManagerType3 = 3;

        /// <summary>
        /// 四级管理员
        /// </summary>
        public const int ManagerType4 = 4;

        /// <summary>
        /// 五级管理员
        /// </summary>
        public const int ManagerType5 = 5;

    }
    #endregion

    #region 发送短信返回结果
    /// <summary>
    /// 发送短信返回结果
    /// </summary>
    public static class SmsResultInfo
    {
        /// <summary>
        /// 发送短信成功
        /// </summary>
        public const string Code_Success = "E0";
        public const string Msg_Success = "";

        /// <summary>
        /// 发送短信失败-账户余额不足
        /// </summary>
        public const string Code_noBalance = "E1";
        public const string Msg_noBalance = "短信账户余额不足，请购买短信！";

        /// <summary>
        /// 发送短信失败-没有手机号
        /// </summary>
        public const string Code_noPhone = "E2";
        public const string Msg_noPhone = "无法发送短信：请选择收信人手机号！";

        /// <summary>
        /// 发送短信失败-手机号不正确
        /// </summary>
        public const string Code_errPhoneNum = "E3";
        public const string Msg_errPhoneNum = "不是正确的手机号，请修改。";

        /// <summary>
        /// 发送短信失败-没有短信内容
        /// </summary>
        public const string Code_noContent = "E4";
        public const string Msg_noContent = "无法发送短信：请填写短息内容！";

        /// <summary>
        /// 发送短信内容-短息内容太长
        /// </summary>
        public const string Code_LongContent = "E5";
        public const string Msg_LongContent = "短信内容太长，请调整后再发送！(短信内容最多允许140个字)";

        /// <summary>
        /// 发送短信内容-短信格式不正确
        /// </summary>
        public const string Code_errContent = "E6";
        public const string Msg_errContent = "短信格式不正确：短信内容必须以[署名]结尾！";

    }
    #endregion

    #region 短信字数
    /// <summary>
    /// 短信字数
    /// </summary>
    public static class SMSWords
    {
        /// <summary>
        /// 群发短信等140字
        /// </summary>
        public const int small = 140;

        /// <summary>
        /// 一般短信500字
        /// </summary>
        public const int normal = 500;

    }
    #endregion

    #region 每条短信记录可发送手机号的个数
    /// <summary>
    /// 每条短信记录可发送手机号的个数
    /// </summary>
    public static class SMSMaxMobileCnt
    {
        /// <summary>
        /// 每次发送200个手机号
        /// </summary>
        public const int cnt200 = 200;

        /// <summary>
        /// 每次发送100个手机号
        /// </summary>
        public const int cnt100 = 100;

    }
    #endregion

    #region 充值状态
    /// <summary>
    /// 充值状态
    /// </summary>
    public static class ChargeState
    {
        /// <summary>
        /// 正在充值
        /// </summary>
        public const int Charging = 1;

        /// <summary>
        /// 充值成功
        /// </summary>
        public const int ChargeSuccess = 2;

        /// <summary>
        /// 充值失败
        /// </summary>
        public const int ChargeFaile = 3;

    }
    #endregion

    #region 访问WebService序列号状态
    /// <summary>
    /// 访问WebService序列号状态
    /// </summary>
    public static class LoginAuthNoState
    {
        /// <summary>
        /// 未使用
        /// </summary>
        public const int NoUse = 0;

        /// <summary>
        /// 已使用
        /// </summary>
        public const int Use = 1;
    }
    #endregion

    #region 登录注册来源
    /// <summary>
    /// 登录注册来源
    /// </summary>
    public static class LoginRegFrom
    {
        /// <summary>
        /// 浏览器
        /// </summary>
        public const int Browser = 0;

        /// <summary>
        /// 客户端
        /// </summary>
        public const int Client = 1;

    }
    #endregion
}
