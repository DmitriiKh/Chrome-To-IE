function redirectToIE() {
    chrome.tabs.query({currentWindow: true, active: true}, function (tabs) {
        var tab = tabs[0];
        var currentUrl = tab.url;

        chrome.extension.sendNativeMessage('com.ms.ie', {
            url: currentUrl
        });

        chrome.tabs.remove(tab.id, function() { });
    });
}

chrome.extension.onRequest.addListener(function () {
    redirectToIE();
});