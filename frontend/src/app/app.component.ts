import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PerfectNumberComponent } from './perfect-number/perfect-number.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PerfectNumberComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'innonum';
}
