﻿using System;

namespace RPDP
{
    public static class MayBe
    {
        public static TResult With<TInput, TResult>(
            this TInput o
            , Func<TInput, TResult> evaluator)
            where TInput : class where TResult : class
        {
            return o == null ? null : evaluator(o);
        }

        public static TResult Return<TInput, TResult>(
            this TInput o,
            Func<TInput, TResult> evaluator,
            TResult failureEvaluator)
            where TInput : class
        {
            return o == null ? failureEvaluator : evaluator(o);
        }

        public static Boolean ReturnSucceess<TInput>(this TInput o) where TInput : class => o != null;

        public static TInput If<TInput>(this TInput o, Predicate<TInput> evaluator) where TInput : class
        {
            if (o == null) return null;
            return evaluator(o) ? o : null;
        }

        public static TInput Do<TInput>(this TInput o, Action<TInput> action) where TInput : class
        {
            if (o == null) return null;
            action(o);
            return o;
        }
    }
}