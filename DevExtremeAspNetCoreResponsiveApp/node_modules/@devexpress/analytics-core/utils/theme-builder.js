const fs = require("fs"),
      path = require("path");

var defaultThemes = {
    "generic": {
        colorSchemes: {
            "light":      { path: "dx-light-style.less" },
            "dark":       { path: "dx-dark-style.less" },
            "carmine":    { path: "dx-carmine-style.less" },
            "greenmist":  { path: "dx-greenmist-style.less" },
            "softblue":   { path: "dx-softblue-style.less" },
            "darkmoon":   { path: "dx-darkmoon-style.less" },
            "darkviolet": { path: "dx-darkviolet-style.less" },
        }
    }
};

function buildTheme(nodeLess, baseTheme, variables) {
    var resolvePath = (lessFileName) => path.resolve(path.join(__dirname, "../less"), lessFileName)

    var baseTheme = baseTheme || "generic.light";
    var themeComponents = baseTheme.split(".");
    var themeType = themeComponents[0] || "";
    var colorScheme = themeComponents[1] || "";
    var sizeScheme = themeComponents[2] || "";
    
    var themeFile = resolvePath(defaultThemes[themeType].colorSchemes[colorScheme].path);
    
    var analyticsVariables = (variables || []).reduce((acc, value) => {
        acc[value.key.replace("@", "")] = value.value;
        return acc;
    }, {});

    return nodeLess.render(fs.readFileSync(themeFile, "utf8"), {
        modifyVars: analyticsVariables,
        rootpath: resolvePath(""),
        paths: [resolvePath("")]
    });
}

module.exports.buildTheme = buildTheme;
