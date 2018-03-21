import { Command } from 'src/commands/Command';
import * as commander from 'commander';

export class GenJsCommand implements Command {

    public register(builder: commander.CommanderStatic): void {
        builder.command('gen-js')
            .option('--baseDir <baseDir>', 'Plexus Metadata base directory')
            .action((opts) => {

                // tslint:disable-next-line:no-console
                console.log(opts.baseDir);
            })
            // tslint:disable-next-line:no-console
            .on('--help', () => { console.log('help stuff for your cluster subcommand...'); });
    }

}
