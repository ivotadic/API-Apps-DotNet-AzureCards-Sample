// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace AzureCards.ConsoleClient.Models
{
    public partial class Card
    {
        private string _face;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Face
        {
            get { return this._face; }
            set { this._face = value; }
        }
        
        private string _suit;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Suit
        {
            get { return this._suit; }
            set { this._suit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Card class.
        /// </summary>
        public Card()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken faceValue = inputObject["Face"];
                if (faceValue != null && faceValue.Type != JTokenType.Null)
                {
                    this.Face = ((string)faceValue);
                }
                JToken suitValue = inputObject["Suit"];
                if (suitValue != null && suitValue.Type != JTokenType.Null)
                {
                    this.Suit = ((string)suitValue);
                }
            }
        }
    }
}
