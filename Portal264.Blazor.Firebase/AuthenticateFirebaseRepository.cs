﻿using Firebase.Auth;
using Portal264.Blazor.Firebase.Common;
using System;
using System.Threading.Tasks;

namespace Portal264.Blazor.Firebase
{
    public class AuthenticateFirebaseRepository : IAuthenticateRepository
    {
        private FirebaseAuthLink _authLink;

        public async Task<bool> LoginAsync(string mailAddress, string password)
        {
            try
            {
                var auth = new FirebaseAuthProvider(new FirebaseConfig(FirebaseToken.ApiKey));
                _authLink = await auth.SignInWithEmailAndPasswordAsync(mailAddress, password);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
