export class Course {
    private _id: string;
    private _title: string;
    private _points: number;
    private _imageUrl: string | undefined;

    constructor(id: string, title: string, points: number, imageUrl?: string) {
        this._id = id;
        this._title = title;
        this._points = points;
        this._imageUrl = imageUrl;
    }

    public get id(): string {
        return this._id;
    }
    public set id(value: string) {
        this._id = value;
    }

    public get title(): string {
        return this._title;
    }
    public set title(value: string) {
        this._title = value;
    }

    public get points(): number {
        return this._points;
    }
    public set points(value: number) {
        this._points = value;
    }

    public get imageUrl(): string | undefined {
        return this._imageUrl;
    }
    public set imageUrl(value: string) {
        this._imageUrl = value;
    }
}
