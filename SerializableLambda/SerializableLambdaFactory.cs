using System;
using System.Linq.Expressions;

namespace SerializableLambda
{
    public static class SerializableLambdaFactory
    {
        public static SerializableLambda<TReturn> Create<TClass, TReturn>(
            Expression<Func<TClass, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn>(method).Create();
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam> Create<TClass, TReturn, TParam>(
            Expression<Func<TClass, TParam, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2> Create<TClass, TReturn, TParam1, TParam2>(
            Expression<Func<TClass, TParam1, TParam2, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3> Create<TClass, TReturn, TParam1,
            TParam2, TParam3>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4, TParam5>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TParam5, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(method);
        
        public static SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9> Create<TClass, TReturn,
            TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(
            Expression<Func<TClass, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TReturn>> method) where TClass : class =>
            new SerializableLambdaBuilder<TClass, TReturn, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(method);
    }
}