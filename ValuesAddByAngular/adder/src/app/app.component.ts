import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  x = 1;
  y = 2;
  result = 3;

  go() {
    this.result = this.x + this.y;
  }
}
