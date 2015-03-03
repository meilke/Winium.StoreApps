﻿namespace WindowsUniversalAppDriver.Common
{
    #region

    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    #endregion

    public class Command
    {
        #region Constructors and Destructors

        public Command(string name, IDictionary<string, JToken> parameters)
        {
            this.Name = name;
            this.Parameters = parameters;
        }

        public Command(string name, string jsonParameters)
            : this(name, JObject.Parse(jsonParameters))
        {
        }

        public Command(string name)
            : this(name, new JObject())
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the command name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the parameters of the command
        /// </summary>
        [JsonProperty("parameters")]
        public IDictionary<string, JToken> Parameters { get; set; }

        /// <summary>
        /// Gets the SessionID of the command
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        #endregion
    }
}
