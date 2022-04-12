﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HraveMzdy.Procezor.Registry.Constants;

namespace HraveMzdy.Procezor.Payrolex.Registry.Constants
{
    public enum PayrolexArticleConst : Int32
    {
        ARTICLE_CONTRACT_WORK_TERM,
        ARTICLE_POSITION_WORK_TERM,
        ARTICLE_POSITION_WORK_PLAN,
        ARTICLE_POSITION_TIME_PLAN,
        ARTICLE_POSITION_TIME_WORK,
        ARTICLE_POSITION_TIME_ABSC,
        ARTICLE_CONTRACT_TIME_PLAN,
        ARTICLE_CONTRACT_TIME_WORK,
        ARTICLE_CONTRACT_TIME_ABSC,
        ARTICLE_PAYMENT_SALARY,
        ARTICLE_PAYMENT_BONUS,
        ARTICLE_PAYMENT_WORKED,
        ARTICLE_PAYMENT_BARTER,
        ARTICLE_ALLOWCE_HOFFICE,
        ARTICLE_HEALTH_DECLARE,
        ARTICLE_HEALTH_INCOME,
        ARTICLE_HEALTH_BASE,
        ARTICLE_HEALTH_BASE_EMPLOYEE,
        ARTICLE_HEALTH_BASE_EMPLOYER,
        ARTICLE_HEALTH_BASE_MANDATE,
        ARTICLE_HEALTH_BASE_OVERCAP,
        ARTICLE_HEALTH_PAYM_EMPLOYEE,
        ARTICLE_HEALTH_PAYM_EMPLOYER,
        ARTICLE_SOCIAL_DECLARE,
        ARTICLE_SOCIAL_INCOME,
        ARTICLE_SOCIAL_BASE,
        ARTICLE_SOCIAL_BASE_EMPLOYEE,
        ARTICLE_SOCIAL_BASE_EMPLOYER,
        ARTICLE_SOCIAL_BASE_OVERCAP,
        ARTICLE_SOCIAL_PAYM_EMPLOYEE,
        ARTICLE_SOCIAL_PAYM_EMPLOYER,
        ARTICLE_TAXING_DECLARE,
        ARTICLE_TAXING_SIGNING,
        ARTICLE_TAXING_INCOME_SUBJECT,
        ARTICLE_TAXING_INCOME_HEALTH,
        ARTICLE_TAXING_INCOME_SOCIAL,
        ARTICLE_TAXING_ADVANCES_INCOME,
        ARTICLE_TAXING_ADVANCES_HEALTH,
        ARTICLE_TAXING_ADVANCES_SOCIAL,
        ARTICLE_TAXING_ADVANCES_BASIS,
        ARTICLE_TAXING_SOLIDARY_BASIS,
        ARTICLE_TAXING_ADVANCES,
        ARTICLE_TAXING_SOLIDARY,
        ARTICLE_TAXING_ADVANCES_TOTAL,
        ARTICLE_TAXING_ALLOWANCE_PAYER,
        ARTICLE_TAXING_ALLOWANCE_CHILD,
        ARTICLE_TAXING_ALLOWANCE_DISAB,
        ARTICLE_TAXING_ALLOWANCE_STUDY,
        ARTICLE_TAXING_REBATE_PAYER,
        ARTICLE_TAXING_REBATE_CHILD,
        ARTICLE_TAXING_BONUS_CHILD,
        ARTICLE_TAXING_WITHHOLD_INCOME,
        ARTICLE_TAXING_WITHHOLD_HEALTH,
        ARTICLE_TAXING_WITHHOLD_SOCIAL,
        ARTICLE_TAXING_WITHHOLD_BASIS,
        ARTICLE_TAXING_WITHHOLD_TOTAL,
        ARTICLE_TAXING_PAYM_ADVANCES,
        ARTICLE_TAXING_PAYM_WITHHOLD,
        ARTICLE_INCOME_GROSS,
        ARTICLE_INCOME_NETTO,
        ARTICLE_EMPLOYER_COSTS,
    }
    public static class ServiceArticleExtensions
    {
        public static string GetSymbol(this PayrolexArticleConst article)
        {
            return article.ToString();
        }
    }
    class ServiceArticleEnumUtils : EnumConstUtils<PayrolexArticleConst>
    {
    }
}