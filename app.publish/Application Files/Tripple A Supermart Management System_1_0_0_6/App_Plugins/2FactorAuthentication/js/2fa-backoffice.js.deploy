// backoffice flow
angular.module('umbraco').controller('twoFactorAuthy.dashboard.controller', function ($scope, $http) {

    $scope.currentPage = "home";

    $scope.data = null;
    $scope.isLoading = true;
    $scope.settingsLoaded = false;

    $scope.twoFactorEnabled = false;
    $scope.userPhoneNumber = "";

    $scope.user = null;

    $scope.responseResult = {
        isSuccess: true,
        error: ""
    }

    $scope.setupData = {
        codeSended: false,
        phoneNumber: null,
        smsCode: null,
        sendedTime: null,
        phoneConfirmed: false
    };

    $scope.proccesseResponse = function (response) {
        $scope.responseResult.isSuccess = response.code == 200;
        $scope.responseResult.error = response.error;
    }

    $scope.loadUserInfo = function () {
        $scope.isLoading = true;
        return $http.get('/umbraco/backoffice/UmbracoApi/Authentication/GetCurrentUser').then(function (response) {
            $scope.user = response.data;
            $scope.settingsLoaded = true;
            $scope.isLoading = false;
        });
    };

    $scope.loadTwoFactorEnabled = function () {
        $scope.isLoading = true;
        return $http.post('/umbraco/backoffice/TwoFaTools/TwoFa/Is2FaEnabled')
            .then(function (response) {
                $scope.proccesseResponse(response.data);
                if ($scope.responseResult.isSuccess) {
                    $scope.twoFactorEnabled = response.data.data;
                    $scope.settingsLoaded = true;
                }
                if ($scope.twoFactorEnabled) {
                    $scope.loadUserPhoneNumber();
                }
                $scope.isLoading = false;
            });
    };

    $scope.loadUserPhoneNumber = function () {
        $scope.isLoading = true;
        return $http.get('/umbraco/backoffice/TwoFaTools/TwoFa/GetSecurePhoneNumber')
            .then(function (response) {
                $scope.proccesseResponse(response.data);
                if ($scope.responseResult.isSuccess) {
                    $scope.userPhoneNumber = response.data.data;
                }
                $scope.isLoading = false;
            });
    };

    $scope.setupAccount = function () {
        $scope.isLoading = true;
        $scope.currentPage = "setupWizard";
        $scope.isLoading = false;
    };

    $scope.sendVerifyCode = function (phoneNumber) {
        $scope.isLoading = true;
        return $http.post('/umbraco/backoffice/TwoFaTools/TwoFa/SendVerifyCode', { phoneNumber: phoneNumber })
            .then(function (response) {
                $scope.proccesseResponse(response.data);
                if ($scope.responseResult.isSuccess) {
                    $scope.setupData.codeSended = $scope.responseResult.isSuccess;
                    $scope.setupData.sendedDateTime = new Date();
                }
                $scope.isLoading = false;
            });
    };

    $scope.confirm2FaAuth = function (phoneNumber, code) {
        $scope.isLoading = true;
        return $http.post('/umbraco/backoffice/TwoFaTools/TwoFa/Confirm2FaAuth', { phoneNumber: phoneNumber, code: code })
            .then(function (response) {
                $scope.proccesseResponse(response.data);
                if ($scope.responseResult.isSuccess) {
                    $scope.setupData.phoneConfirmed = $scope.responseResult.isSuccess
                    $scope.currentPage = "home";
                    $scope.loadTwoFactorEnabled();
                }
                $scope.isLoading = false;
            });
    };

    $scope.removeAuthenticator = function () {
        $scope.isLoading = true
        return $http.post('/umbraco/backoffice/TwoFaTools/TwoFa/Enable2Fa', { isTwoFactorEnabled: false }).then(function (response) {
            $scope.proccesseResponse(response.data);
            if ($scope.responseResult.isSuccess) {
                $scope.currentPage = "home";
                $scope.loadTwoFactorEnabled();
            }
            $scope.isLoading = false
        });
    };

    $scope.loadUserInfo();
    $scope.loadTwoFactorEnabled();
});
