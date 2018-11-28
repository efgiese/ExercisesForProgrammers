import { Component } from '@angular/core';
import { SquareCeiling, RoundCeiling, Ceiling, LshapeCeiling } from './shared/ceiling';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Paint Calculator';
}
