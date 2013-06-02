using System;
using System.Linq;
using System.Reflection;

namespace SpellWork.Extensions
{
    public enum CompareType
    {
        [FullName("x != y")]
        NotEqual,
        [FullName("x == y")]
        Equal,

        [FullName("x != 0")]
        NotEmpty,

        [FullName("x > y")]
        GreaterThan,
        [FullName("x >= y")]
        GreaterOrEqual,
        [FullName("x < y")]
        LowerThan,
        [FullName("x <= y")]
        LowerOrEqual,

        [FullName("x & y == y")]
        AndStrict,
        [FullName("x & y != 0")]
        And,
        [FullName("x & y == 0")]
        NotAnd,

        [FullName("x Starts With y")]
        StartsWith,
        [FullName("x Ends With y")]
        EndsWith,
        [FullName("x Contains y")]
        Contains,
    }

    public static class LinqExtensions
    {
        /// <summary>
        /// Compares two values object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entry"></param>
        /// <param name="field">Value Type is MemberInfo</param>
        /// <param name="val"></param>
        /// <param name="compareType"></param>
        /// <returns></returns>
        public static bool CreateFilter<T>(this T entry, object field, object val, CompareType compareType)
        {
            var basicValue = GetValue(entry, (MemberInfo)field);

            switch (basicValue.GetType().Name)
            {
                case "UInt32":
                    return Compare(basicValue.ToUInt32(), val.ToUInt32(), compareType);
                case "Int32":
                    return Compare(basicValue.ToInt32(), val.ToInt32(), compareType);
                case "Single":
                    return Compare(basicValue.ToFloat(), val.ToFloat(), compareType);
                case "UInt64":
                    return Compare(basicValue.ToUlong(), val.ToUlong(), compareType);
                case "String":
                    return Compare(basicValue.ToString(), val.ToString(), compareType);
                case @"UInt32[]":
                {
                    var valUint = val.ToUInt32();
                    return ((uint[])basicValue).Any(el => Compare(el, valUint, compareType));
                }
                case @"Int32[]":
                {
                    var valInt = val.ToInt32();
                    return ((int[])basicValue).Any(el => Compare(el, valInt, compareType));
                }
                case @"Single[]":
                {
                    var valFloat = val.ToFloat();
                    return ((float[])basicValue).Any(el => Compare(el, valFloat, compareType));
                }
                case @"UInt64[]":
                {
                    var valUlong = val.ToUlong();
                    return ((ulong[])basicValue).Any(el => Compare(el, valUlong, compareType));
                }
                default:
                    return false;
            }
        }

        #region Specific Compares

        private static Boolean Compare(String baseValue, String value, CompareType compareType)
        {
            switch (compareType)
            {
                case CompareType.StartsWith:
                    return baseValue.StartsWith(value);
                case CompareType.EndsWith:
                    return baseValue.EndsWith(value);

                case CompareType.Contains:
                    return baseValue.ContainsText(value);

                case CompareType.NotEmpty:
                    return !"0".Equals(baseValue, StringComparison.CurrentCultureIgnoreCase);

                case CompareType.NotEqual:
                    return !baseValue.Equals(value, StringComparison.CurrentCultureIgnoreCase);
                case CompareType.Equal:
                default:
                    return baseValue.Equals(value, StringComparison.CurrentCultureIgnoreCase);
            }
        }

        private static Boolean Compare(float baseValue, float value, CompareType compareType)
        {
            switch (compareType)
            {
                case CompareType.GreaterOrEqual:
                    return baseValue >= value;
                case CompareType.GreaterThan:
                    return baseValue > value;
                case CompareType.LowerOrEqual:
                    return baseValue <= value;
                case CompareType.LowerThan:
                    return baseValue < value;

                case CompareType.NotEmpty:
                    return baseValue != 0;

                case CompareType.NotEqual:
                    return baseValue != value;
                case CompareType.Equal:
                default:
                    return baseValue == value;
            }
        }

        private static Boolean Compare(UInt64 baseValue, UInt64 value, CompareType compareType)
        {
            switch (compareType)
            {
                case CompareType.GreaterOrEqual:
                    return baseValue >= value;
                case CompareType.GreaterThan:
                    return baseValue > value;
                case CompareType.LowerOrEqual:
                    return baseValue <= value;
                case CompareType.LowerThan:
                    return baseValue < value;

                case CompareType.NotEmpty:
                    return baseValue != 0;

                case CompareType.AndStrict:
                    return (baseValue & value) == value;
                case CompareType.And:
                    return (baseValue & value) != 0;
                case CompareType.NotAnd:
                    return (baseValue & value) == 0;

                case CompareType.NotEqual:
                    return baseValue != value;
                case CompareType.Equal:
                default:
                    return baseValue == value;
            }
        }

        private static Boolean Compare(Int32 baseValue, Int32 value, CompareType compareType)
        {
            switch (compareType)
            {
                case CompareType.GreaterOrEqual:
                    return baseValue >= value;
                case CompareType.GreaterThan:
                    return baseValue > value;
                case CompareType.LowerOrEqual:
                    return baseValue <= value;
                case CompareType.LowerThan:
                    return baseValue < value;

                case CompareType.NotEmpty:
                    return baseValue != 0;

                case CompareType.AndStrict:
                    return (baseValue & value) == value;
                case CompareType.And:
                    return (baseValue & value) != 0;
                case CompareType.NotAnd:
                    return (baseValue & value) == 0;

                case CompareType.NotEqual:
                    return baseValue != value;
                case CompareType.Equal:
                default:
                    return baseValue == value;
            }
        }

        private static Boolean Compare(UInt32 baseValue, UInt32 value, CompareType compareType)
        {
            switch (compareType)
            {
                case CompareType.GreaterOrEqual:
                    return baseValue >= value;
                case CompareType.GreaterThan:
                    return baseValue > value;
                case CompareType.LowerOrEqual:
                    return baseValue <= value;
                case CompareType.LowerThan:
                    return baseValue < value;

                case CompareType.NotEmpty:
                    return baseValue != 0;

                case CompareType.AndStrict:
                    return (baseValue & value) == value;
                case CompareType.And:
                    return (baseValue & value) != 0;
                case CompareType.NotAnd:
                    return (baseValue & value) == 0;

                case CompareType.NotEqual:
                    return baseValue != value;
                case CompareType.Equal:
                default:
                    return baseValue == value;
            }
        }

        #endregion

        private static Object GetValue<T>(T entry, MemberInfo field)
        {
            if (field is FieldInfo)
                return typeof(T).GetField(field.Name).GetValue(entry);
            if (field is PropertyInfo)
                return typeof(T).GetProperty(field.Name).GetValue(entry, null);
            return null;
        }
    }
}
