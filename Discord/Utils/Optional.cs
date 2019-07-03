using System;

namespace dotBridge.Discord.Utils
{
    /// <summary>
    /// Optional value for Discord API
    /// </summary>
    /// <typeparam name="T">Type of the value</typeparam>
    public class Optional<T>
    {
        #region Variables
        
        private readonly T _value;

        /// <summary>
        /// Whether this optional field has a value
        /// </summary>
        public bool HasValue { get; }

        /// <summary>
        /// Get the value
        /// </summary>
        /// <exception cref="InvalidOperationException">Optional field doesn't have a value</exception>
        public T Value
        {
            get
            {
                if (!HasValue)
                    throw new InvalidOperationException();

                return _value;
            }
        }
        
        #endregion
        
        #region Constructors

        public Optional(T value)
        {
            _value = value;
            HasValue = true;
        }

        public Optional()
        {
            _value = default(T);
            HasValue = false;
        }
        
        #endregion
        
        #region Getting value

        /// <summary>
        /// Get value or default if field has no value
        /// </summary>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Value or <see cref="defaultValue"/></returns>
        public T GetValue(T defaultValue = default(T)) => HasValue ? _value : defaultValue;
        
        #endregion
        
        #region Overriding

        public override bool Equals(object obj)
        {
            if (!HasValue)
                return obj == null;
            
            return obj != null && _value.Equals(obj);
        }

        public override int GetHashCode() => HasValue ? _value.GetHashCode() : 0;

        public override string ToString() => HasValue ? _value.ToString() : string.Empty;
        
        #endregion
        
        #region Implicit & Explicit operators

        public static implicit operator Optional<T>(T value) => new Optional<T>(value);
        public static explicit operator T(Optional<T> value) => value.Value;

        #endregion
    }

    public static class Optional
    {
        /// <summary>
        /// Get nullable value or default if field has no value
        /// </summary>
        /// <param name="value">Optional field instance</param>
        /// <param name="defaultValue">Default value</param>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Nullable of the value</returns>
        public static T? GetNullableValue<T>(this Optional<T> value, T? defaultValue = null) where T : struct =>
            value.HasValue ? value.Value : defaultValue;
    }
}