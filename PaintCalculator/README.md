# PaintCalculator

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 7.0.6.

It has started as a plain Angular project. I added nativescript-schematics to build both web and mobile apps from a single project. For details see the [NativeScript docs](https://docs.nativescript.org/angular/code-sharing/migrating-a-web-project).

```node
ng add @nativescript/schematics
```

## After adding the nativescript-schematics

```node
NativeScript Webpack plugin was successfully added.
You can now bundle your project by passing --bundle flag to NativeScript CLI commands:
    - tns build android --bundle
    - tns build ios --bundle
    - tns run android --bundle
    - tns run ios --bundle
You can also pass the "--env.uglify" flag to use UglifyJS for minification.
For more information check out https://docs.nativescript.org/tooling/bundling-with-webpack#bundling.
```

## Errors

* Removed the autogenerated `app.component.tns.ts`.
* Removed the `applicationId` from the `app.gradle`.
* The Schematics where added twice. Once in production `"@nativescript/schematics": "^0.4.0"` and once in dev `"@nativescript/schematics": "~0.3.0"`. Removed the version from production.
* Updated to `"@angular-devkit/build-angular": "^0.11.0"` and `"nativescript-dev-webpack": "^0.18.0"`
* Removed the `node_modules` and do a fresh `npm install`

### Resulting working package.json

```json
{
  "name": "paint-calculator",
  "version": "0.0.0",
  "scripts": {
    "android": "tns run android --bundle",
    "ios": "tns run ios --bundle",
    "ng": "ng",
    "start": "ng serve",
    "build": "ng build",
    "test": "ng test",
    "lint": "ng lint",
    "e2e": "ng e2e"
  },
  "private": true,
  "dependencies": {
    "@angular/animations": "~7.0.0",
    "@angular/common": "~7.0.0",
    "@angular/compiler": "~7.0.0",
    "@angular/core": "~7.0.0",
    "@angular/forms": "~7.0.0",
    "@angular/http": "~7.0.0",
    "@angular/platform-browser": "~7.0.0",
    "@angular/platform-browser-dynamic": "~7.0.0",
    "@angular/router": "~7.0.0",
    "bootstrap": "^4.1.3",
    "core-js": "^2.5.4",
    "jquery": "^3.3.1",
    "nativescript-angular": "~7.0.0",
    "nativescript-theme-core": "~1.0.4",
    "popper.js": "^1.14.5",
    "reflect-metadata": "~0.1.8",
    "rxjs": "~6.3.3",
    "tns-core-modules": "~5.0.0",
    "zone.js": "~0.8.26"
  },
  "devDependencies": {
    "@angular-devkit/build-angular": "^0.11.0",
    "@angular/cli": "~7.0.6",
    "@angular/compiler-cli": "~7.0.0",
    "@angular/language-service": "~7.0.0",
    "@nativescript/schematics": "~0.3.0",
    "@types/jasmine": "~2.8.8",
    "@types/jasminewd2": "~2.0.3",
    "@types/node": "~8.9.4",
    "codelyzer": "~4.5.0",
    "jasmine-core": "~2.99.1",
    "jasmine-spec-reporter": "~4.2.1",
    "karma": "~3.0.0",
    "karma-chrome-launcher": "~2.2.0",
    "karma-coverage-istanbul-reporter": "~2.0.1",
    "karma-jasmine": "~1.1.2",
    "karma-jasmine-html-reporter": "^0.2.2",
    "nativescript-dev-webpack": "^0.18.0",
    "protractor": "~5.4.0",
    "ts-node": "~7.0.0",
    "tslint": "~5.11.0",
    "typescript": "~3.1.6"
  },
  "nativescript": {
    "id": "de.egiese.PaintCalculator",
    "tns-android": {
      "version": "5.0.0"
    }
  }
}
```

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).
