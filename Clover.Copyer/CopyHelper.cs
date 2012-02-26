using System;
using System.Reflection.Emit;
using System.Reflection;

namespace Clover.Copyer
{
    public static class CopyHelper<TSource, TTarget>
    {
        private static CopyAction<TSource, TTarget> action = null;
        static CopyHelper()
        {
            Type[] args = { typeof(TSource), typeof(TTarget) };
            DynamicMethod convertMethod = new DynamicMethod("Convert", typeof(void), args);
            ILGenerator convertIL = convertMethod.GetILGenerator();
            var ps = typeof(TTarget).GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var p2 in ps)
            {
                if (p2.GetIndexParameters().Length == 0)
                {
                    var p1 = typeof(TSource).GetProperty(p2.Name);
                    if (p1 != null && p1.GetIndexParameters().Length == 0)
                    {
                        convertIL.Emit(OpCodes.Ldarg_1);
                        convertIL.Emit(OpCodes.Ldarg_0);
                        convertIL.Emit(OpCodes.Callvirt, p1.GetGetMethod());
                        convertIL.Emit(OpCodes.Callvirt, p2.GetSetMethod());
                    }
                }
            }
            convertIL.Emit(OpCodes.Ret);
            action = (CopyAction<TSource, TTarget>)convertMethod.CreateDelegate(typeof(CopyAction<TSource, TTarget>));
        }
        /// <summary>
        /// Copy value from t to k
        /// </summary>
        /// <param name="t">source</param>
        /// <param name="k">target</param>
        public static void Copy(TSource t, TTarget k)
        {
            action(t, k);
        }
    }
   
    public delegate void CopyAction<T, K>(T t, K k);
    
}
