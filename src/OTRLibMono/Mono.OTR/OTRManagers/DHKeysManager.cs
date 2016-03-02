using System;

using Org.BouncyCastle.Math;

using Mono.OTR.Utilities;


namespace Mono.OTR.Managers
{
	  public class DHKeysManager
    {
        private UInt32 key_serial = 0;
                
        public DHKeysManager()
        {
           
        }

        public DHKeyPair GenerateKeyPair()
        {
           key_serial++;

           DHKeyPair _key_pair = new DHKeyPair(key_serial);

           _key_pair.SetPrivateKey(Utility.GetRandomBigInt(OTRConstants.DH_PRIVATE_KEY_MINIMUM_LENGTH_BITS));
		  _key_pair.SetPublicKey(OTRConstants.RFC_3526_GENERATOR().ModPow(_key_pair.GetPrivateKey(),OTRConstants.RFC_3526_PRIME_MODULO()));
						
           
            return _key_pair;

        }
               
       
   
    
    }
}

