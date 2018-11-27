import { Component } from '@angular/core';
import { SquareCeiling } from './shared/ceiling';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Paint Calculator';
  submitted = false;
  aLenght: number;
  aWidth: number;
  squareMeter: number;
  liter: number;
  ceiling: SquareCeiling;

  onSubmit() {
    this.submitted = true;
    this.ceiling = new SquareCeiling(this.aLenght, this.aWidth);
    this.squareMeter = this.ceiling.squareMeter;
    this.liter = this.ceiling.liter;
  }
}
