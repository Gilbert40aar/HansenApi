import { EventEmitter, Injectable, Output } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { ILogin } from '../interfaces/ilogin';
import { ITokenPayload } from '../interfaces/itokenpayload';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  token: string = '';

  @Output() OnLoginSuccessful: EventEmitter<any> = new EventEmitter<any>();
  @Output() OnLogoutSuccessful: EventEmitter<any> = new EventEmitter<any>();

  constructor(private api: ApiService, private jwt: JwtHelperService) {
    let token = localStorage.getItem('token');

    if (token) {
      this.token = token;
      this.OnLoginSuccessful.emit();
    }
  }

  login(login: ILogin): void {
    try {
      this.api.login(login).subscribe(data => {
        this.token = data.token;
        localStorage.setItem('token', data.token);

        this.OnLoginSuccessful.emit();
      });
    } catch (error) {
      console.error(error);
    }
  }

  logout(): void {
      this.token = '';
      localStorage.removeItem('token');
      this.OnLogoutSuccessful.emit();
  }

  private get package(): ITokenPayload | null {
    return this.jwt.decodeToken<ITokenPayload>(this.token);
  }

  get authenticated(): boolean {
    if (!this.package) return false;

    let current: Date = new Date();

    let exp: Date | undefined = this.package?.exp ? new Date(this.package?.exp * 1000) : undefined;
    let nbf: Date | undefined = this.package?.nbf ? new Date(this.package?.nbf * 1000) : undefined;

    if (exp && current > exp) return false;
    if (nbf && current < nbf) return false;

    return true;
  }

  get id(): number | null {
    return this.package && this.package.id ? this.package.id : null;
  }

  get rule(): string | null {
    return this.package && this.package.rule ? this.package.rule : null;
  }

  get fullname(): string | null {
    return this.package ? `${this.firstname} ${this.lastname}` : null;
  }

  get firstname(): string | null {
    return this.package && this.package.firstname ? this.package.firstname : null;
  }

  get lastname(): string | null {
    return this.package && this.package.lastname ? this.package.lastname : null;
  }

}
