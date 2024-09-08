angular.module("umbraco").controller("2FactorAuthentication.LoginController",
    function ($scope, $cookies, localizationService, userService, externalLoginInfo, resetPasswordCodeInfo, $timeout, authResource, editorService, twoFactorService) {

        $scope.code = "";
        $scope.provider = "Twilio Authy";
        $scope.providers = [];
        $scope.step = "send";
        
        authResource.get2FAProviders()
            .then(function (data) {
                $scope.providers = data;
            });
        $scope.providers = "Twilio Authy"; //temp
        $scope.step = "send";

        $scope.send = function (provider) {
            $scope.provider = provider;
            $scope.step = "code";
            authResource.send2FACode(provider)
                .then(function (data) {
                    console.log(data);
                });
        };

        //for Assets case we need to skip provider choosing step and go to "code" step

        $scope.send($scope.provider);

        //

        $scope.validate = function (provider, code) {
            provider = "Twilio Authy"; //temp
            $scope.error2FA = "";
            $scope.code = code;
            authResource.verify2FACode(provider, code)
                .then(function (data) {
                    userService.setAuthenticationSuccessful(data);
                    $scope.$parent.vm.onLogin();
                }, function () { $scope.error2FA = "Invalid code entered." });
        };
    });

angular.module("umbraco.services").factory("twoFactorService",
    function ($http) {

        return {
            getEnabled: function (userId) {
                return $http.get("/umbraco/backoffice/api/TwoFactorAuth/TwoFactorEnabled/?userId=" + userId);
            },
            // TODO: not implemented
            getGoogleAuthenticatorSetupCode: function () {
                return $http.get("/umbraco/backoffice/api/TwoFactorAuth/GoogleAuthenticatorSetupCode/");
            },
            validateAndSave: function (code) {
                return $http.post("/umbraco/backoffice/api/TwoFactorAuth/ValidateAndSave/?code=" + code);
            },
            // TODO: not implemented
            validateAndSaveGoogleAuth: function (code) {
                return $http.post("/umbraco/backoffice/api/TwoFactorAuth/ValidateAndSaveGoogleAuth/?code=" + code);
            },
            disable: function () {
                return $http.post("/umbraco/backoffice/api/TwoFactorAuth/Disable/");
            },
            get2FAProviders: function () {
                return $http.post("/umbraco/backoffice/api/TwoFactorAuth/Get2FAProviders/");
            }
        };
    });