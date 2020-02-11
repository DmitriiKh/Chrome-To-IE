# Crome-To-IE

Redirect specific websites from Chrome browser to Internet Explorer.

This project is a solution for redirecting any websites (which can be rendered only with Internet Explorer) to the appropriate browser.

## Getting Started

Unfortunately, there is no installer for this solution in the project at this moment. Therefore, you need to do several things to make it work.

First, change URLs from "stackoverflow.com/*" to the website you want to redirect in the `manifest.json` file:
```"matches": ["http://stackoverflow.com/*", "https://stackoverflow.com/*"],```

Second, install the ChromeToIE extension manually (manifest.json).

Third, compile the BridgeToIE console app.

Fourth, edit `ie-manifest.json` to set the path to `BridgeToIE.exe` and the ChromeToIE extension ID
```"path": "C:\\Users\\Dmitrii\\source\\repos\\ChromeToIE\\BridgeToIE\\bin\\Debug\\BridgeToIE.exe",```
```"chrome-extension://kdbpgladdniidjoelcnlffblapiaehmg/"```

Fifth, edit `ie.reg` to replace the path to `ie-manifest.json` file
```@="C:\\Users\\Dmitrii\\source\\repos\\ChromeToIE\\ie-manifest.json"```

Sixth, double click on `ie.reg' to add it to the Registry.

That's it. Now, if you click on any link leading to the website you added to `manifest.json` as the match, you will have the site opened in Internet Explorer.

### Prerequisites

Windows, Chrome, Internet Explorer

## Deployment

It is up to you. I did not create a deployment solution yet.

## Contributing

You are very welcome to make a pull request if you'd like.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

* Thanks for the inspiration to the developer who asked for help on StackOverflow
* Also, I do not appreciate that another guy who decided to close the discussion before I could post my solution there
